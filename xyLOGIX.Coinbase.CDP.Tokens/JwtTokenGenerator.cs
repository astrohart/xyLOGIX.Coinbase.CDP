using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces;
using xyLOGIX.Coinbase.CDP.Tokens.Interfaces;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Coinbase.CDP.Tokens
{
    /// <summary>
    /// Generates so-called <c>JSON Web Tokens</c> for use on the
    /// <c>Coinbase (Retail)</c> or the <c>Coinbase (Advanced Trade)</c> trading
    /// platform(s).
    /// </summary>
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static JwtTokenGenerator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected JwtTokenGenerator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:xyLOGIX.Coinbase.CDP.Tokens.Interfaces.IJwtTokenGenerator" />
        /// interface.
        /// </summary>
        public static IJwtTokenGenerator Instance { get; } =
            new JwtTokenGenerator();

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

                result = GenerateFor(key.Name, key.PrivateKey);
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
            [NotLogged] string privateKey
        )
        {
            var result = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(name)) return result;
                if (string.IsNullOrWhiteSpace(privateKey)) return result;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }

        private string FormatJwtUri(string method, string path)
            => $"{method.ToUpper()} api.coinbase.com{path}";
    }
}