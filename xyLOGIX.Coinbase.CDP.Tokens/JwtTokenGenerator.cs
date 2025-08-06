using System.Diagnostics;
#pragma warning disable SYSLIB0023 // Disable the obsolete RNGCryptoServiceProvider warning

using Jose;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Threading;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Security.Cryptography;
using xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces;
using xyLOGIX.Coinbase.CDP.Tokens.Interfaces;
using xyLOGIX.Collections.Synchronized;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Coinbase.CDP.Tokens
{
    /// <summary>
    /// Generates so-called <c>JSON Web Tokens</c> for use on the
    /// <c>Coinbase (Retail)</c> or the <c>Coinbase (Advanced Trade)</c> trading
    /// platform(s).
    /// </summary>
    [Synchronized]
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        /// <summary>
        /// A <see cref="T:System.String" /> that contains the name of the audit service.
        /// </summary>
        public const string RETAIL_REST_API_PROXY = "retail_rest_api_proxy";

        /// <summary>
        /// A <see cref="T:System.String" /> value that contains the hostname of the REST
        /// API server.
        /// </summary>
        private const string REQUEST_HOST = "api.coinbase.com";

        /// <summary>
        /// Reference to an instance of <see cref="T:System.Random" /> that generates
        /// random values for the <c>nonce</c>.
        /// </summary>
        private static readonly RandomNumberGenerator _rng;

        /// <summary>
        /// A static readonly HashSet that contains valid HTTP methods.
        /// </summary>
        private static readonly ConcurrentList<string> _validHttpMethods;

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static JwtTokenGenerator()
        {
            _rng = RandomNumberGenerator.Create();

            _validHttpMethods = new ConcurrentList<string>
            {
                HttpMethod.Get.Method,
                HttpMethod.Post.Method,
                HttpMethod.Put.Method,
                HttpMethod.Delete.Method,
                HttpMethod.Head.Method,
                HttpMethod.Options.Method,
                HttpMethod.Trace.Method
            };
        }

        /// <summary>
        /// Empty, private constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        private JwtTokenGenerator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:xyLOGIX.Coinbase.CDP.Tokens.Interfaces.IJwtTokenGenerator" />
        /// interface.
        /// </summary>
        public static IJwtTokenGenerator Instance { [DebuggerStepThrough] get; } =
            new JwtTokenGenerator();

        /// <summary>
        /// Gets the valid HTTP methods.
        /// </summary>
        private static ConcurrentList<string> ValidHttpMethods
            => _validHttpMethods;

        /// <summary>
        /// Attempts to generate a <c>JSON Web Token (JWT)</c> for use on the
        /// <c>Coinbase (Retail)</c> or the <c>Coinbase (Advanced Trade)</c> platform(s).
        /// </summary>
        /// <param name="key">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey" />
        /// interface that represents a private key.
        /// </param>
        /// <param name="method">
        /// (Required.) A <see cref="T:System.String" /> containing the HTTP method name,
        /// e.g., <c>GET</c>, in all uppercase, that is being used for the particular REST
        /// API call for which a JWT is desired.
        /// </param>
        /// <param name="path">
        /// (Required.) A <see cref="T:System.String" /> containing the path, e.g.,
        /// <c>/v2/accounts</c>, that is being used for the particular REST API call for
        /// which a JWT is desired.
        /// </param>
        /// <remarks>
        /// If a <see langword="null" /> reference is passed as the argument of
        /// the <paramref name="key" /> parameter, or its property(ies) do not contain
        /// valid information, then this method returns the
        /// <see cref="F:System.String.Empty" /> value.
        /// </remarks>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> value containing the
        /// JWT token that has been generated, or the <see cref="F:System.String.Empty" />
        /// value if failed.
        /// </returns>
        [return: NotLogged]
        public string GenerateFor(
            ICoinbaseJwtPrivateKey key,
            string method,
            string path
        )
        {
            var result = string.Empty;

            try
            {
                if (key == null) return result;
                if (string.IsNullOrWhiteSpace(method))
                    return result;
                if (string.IsNullOrWhiteSpace(path))
                    return result;

                result = GenerateFor(
                    key.Name, key.PrivateKeyPem, new HttpMethod(method), path
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Attempts to generate a <c>JSON Web Token (JWT)</c> for use on the
        /// <c>Coinbase (Retail)</c> or the <c>Coinbase (Advanced Trade)</c> platform(s).
        /// </summary>
        /// <param name="name">
        /// (Required.) A <see cref="T:System.String" /> containing the name of the API
        /// user's private key.
        /// </param>
        /// <param name="method">
        /// (Required.) A <see cref="T:System.String" /> containing the HTTP method name,
        /// e.g., <c>GET</c>, in all uppercase, that is being used for the particular REST
        /// API call for which a JWT is desired.
        /// </param>
        /// <param name="path">
        /// (Required.) A <see cref="T:System.String" /> containing the path, e.g.,
        /// <c>/v2/accounts</c>, that is being used for the particular REST API call for
        /// which a JWT is desired.
        /// </param>
        /// <param name="privateKey">
        /// (Required.) A <see cref="T:System.String" /> containing the PEM-formatted
        /// private key of the API user.
        /// </param>
        /// <remarks>
        /// If a <see langword="null" /> reference is passed as the argument of
        /// the <paramref name="key" /> parameter, or its property(ies) do not contain
        /// valid information, then this method returns the
        /// <see cref="F:System.String.Empty" /> value.
        /// </remarks>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> value containing the
        /// JWT token that has been generated, or the <see cref="F:System.String.Empty" />
        /// value if failed.
        /// </returns>
        [return: NotLogged]
        public string GenerateFor(
            [NotLogged] string name,
            [NotLogged] string privateKey,
            HttpMethod method,
            string path
        )
        {
            ECDsa privateKeyObject = default;
            var result = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(name)) return result;
                if (string.IsNullOrWhiteSpace(privateKey)) return result;
                if (method == null) return result;
                if (string.IsNullOrWhiteSpace(method.Method)) return result;
                if (string.IsNullOrWhiteSpace(path)) return result;

                var modifiedSecret = privateKey.Replace("\\n", "\n");

                if (string.IsNullOrWhiteSpace(modifiedSecret))
                    return result;

                using (var reader = new StringReader(modifiedSecret))
                {
                    var pemReader = new PemReader(reader);
                    if (pemReader == null) return result;
                    var keyPair =
                        (AsymmetricCipherKeyPair)pemReader.ReadObject();
                    if (keyPair == null) return result;

                    var privateKeyParameters =
                        (ECPrivateKeyParameters)keyPair.Private;
                    if (privateKeyParameters == null) return result;

                    var publicKeyParameters =
                        (ECPublicKeyParameters)keyPair.Public;
                    if (publicKeyParameters == null) return result;

                    // Convert the private key 'D' value to a byte array
                    var d = privateKeyParameters.D.ToByteArrayUnsigned();

                    // Get the public key's elliptic curve point 'Q'
                    var q = publicKeyParameters.Q;

                    // Convert the X and Y coordinates of point 'Q' to byte arrays
                    // These represent the public key components
                    var x = q.AffineXCoord.GetEncoded();
                    var y = q.AffineYCoord.GetEncoded();

                    // Create a new ECDsa object with the specified ECParameters
                    // The ECParameters include the curve details, private key 'D', and public key point 'Q'
                    privateKeyObject = ECDsa.Create(
                        new ECParameters
                        {
                            Curve =
                                ECCurve.NamedCurves
                                       .nistP256, // Specify the elliptic curve used
                            D = d, // Set the private key component
                            Q = new ECPoint
                            {
                                X = x, Y = y
                            } // Set the public key components
                        }
                    );
                }

                if (privateKeyObject == null) return result;

                var request_path = path != null && path.Contains("?")
                    ? path.Substring(0, path.IndexOf('?'))
                    : path;

                var payload = new Dictionary<string, object>
                {
                    { "sub", name },
                    { "iss", "coinbase-cloud" },
                    { "nbf", DateTimeOffset.UtcNow.ToUnixTimeSeconds() },
                    {
                        "exp", DateTimeOffset.UtcNow.AddSeconds(15)
                                             .ToUnixTimeSeconds()
                    },
                    { "aud", new[] { RETAIL_REST_API_PROXY } }
                };

                payload.Add(
                    "uri",
                    $"{method.Method.ToUpperInvariant()} {REQUEST_HOST}{request_path}"
                );

                var nonce = GenerateNonce(10);
                if (string.IsNullOrWhiteSpace(nonce)) return result;

                var extraHeaders = new Dictionary<string, object>
                {
                    { "kid", name }, { "nonce", nonce }, { "typ", "JWT" }
                };

                result = JWT.Encode(
                    payload, privateKey, JwsAlgorithm.ES256, extraHeaders
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }
            finally
            {
                privateKeyObject?.Dispose();
            }

            return result;
        }

        /// <summary>
        /// Generates a unique nonce value.
        /// This method generates a random value which is sufficiently large to
        /// ensure uniqueness and security.
        /// </summary>
        /// <returns>A nonce value as a hexadecimal string.</returns>
        [EntryPoint]
        private static string GenerateNonce(int digits)
        {
            var result = string.Empty;

            try
            {
                if (digits <= 0) return result;

                var buffer = new byte[digits / 2];
                _rng.GetBytes(
                    buffer
                ); // This will fill the buffer with random bytes

                if (buffer == null) return result;
                if (buffer.Length == 0) return result;

                for (var i = 0; i < buffer.Length; i++)
                {
                    var item = buffer[i];
                    result += item.ToString("X2");
                }

                if (digits % 2 == 0) return result;

                var extraBuffer = new byte[1];
                _rng.GetBytes(extraBuffer);
                result += extraBuffer[0]
                    .ToString("X");
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"JwtTokenGenerator.GenerateNonce: Result = '{result}'"
            );

            return result;
        }

        /// <summary>
        /// Formats a URI for use with a JSON web token value, given the specified HTTP
        /// <paramref name="method" /> and <paramref name="path" />.
        /// </summary>
        /// <param name="method">
        /// (Required.) a <see cref="T:System.String" /> that contains
        /// the representation of the HTTP method, such as <c>GET</c>, <c>POST</c>, etc.
        /// being used.
        /// </param>
        /// <param name="path">(Required.) The path and query of the Coinbase API request.</param>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> is returned containing
        /// the properly-formatted URI; otherwise, the <see cref="F:System.String.Empty" />
        /// value is returned.
        /// </returns>
        private string FormatJwtUri(string method, string path)
        {
            var result = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(method)) return result;
                if (string.IsNullOrWhiteSpace(path)) return result;

                // Check that the 'method' is a valid HTTP method
                if (!ValidHttpMethods.Contains(method)) return result;

                result = $"{method.ToUpper()} {REQUEST_HOST}{path}";
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }
    }
}

#pragma warning restore SYSLIB0023 // Restore the warning
