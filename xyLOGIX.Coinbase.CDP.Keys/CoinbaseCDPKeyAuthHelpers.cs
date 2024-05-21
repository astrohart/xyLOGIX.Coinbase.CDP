using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Threading;
using System;
using xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces;
using xyLOGIX.Coinbase.CDP.Keys.Providers;
using xyLOGIX.Coinbase.CDP.Keys.Providers.Factories;
using xyLOGIX.Coinbase.CDP.Tokens.Factories;
using xyLOGIX.Coinbase.CDP.Tokens.Interfaces;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace xyLOGIX.Coinbase.CDP.Keys
{
    [ExplicitlySynchronized]
    public static class CoinbaseCDPKeyAuthHelpers
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the
        /// <see cref="T:xyLOGIX.Coinbase.CDP.Keys.ApiKeyAuthHelpers" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static CoinbaseCDPKeyAuthHelpers() { }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Coinbase.CDP.Tokens.Interfaces.IJwtTokenGenerator" />
        /// interface.
        /// </summary>
        private static IJwtTokenGenerator JwtTokenGenerator { get; } =
            GetJwtTokenGenerator.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Coinbase.CDP.Keys.Providers.ICDPPrivateKeyProvider" />
        /// interface.
        /// </summary>
        private static ICDPPrivateKeyProvider PrivateKeyProvider { get; } =
            GetCDPPrivateKeyProvider.SoleInstance();

        /// <summary>
        /// Gets a <c>JSON Web Token (JWT)</c> value given the specified
        /// <paramref name="method" /> and request <paramref name="url" />.
        /// </summary>
        /// <param name="keyInfo">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey" />
        /// interface representing private-key information on the
        /// <c>Coinbase Developer Platform (CDP)</c>.
        /// </param>
        /// <param name="method">
        /// (Required.) A <see cref="T:System.String" /> that contains
        /// the particular HTTP method, say, for example, <c>GET</c>, <c>PUT</c>, or
        /// <c>POST</c> that is in use for the current request, in all-uppercase letters.
        /// </param>
        /// <param name="url">
        /// (Required.) A <see cref="T:System.String" /> containing the
        /// path and query of a request, e.g., <c>/v2/accounts?expand=all</c>.
        /// </param>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> that contains the JWT
        /// that is to be used; otherwise, the <see cref="F:System.String.Empty" /> value
        /// is returned.
        /// </returns>
        [return: NotLogged]
        public static string GetJWT(
            ICoinbaseJwtPrivateKey keyInfo,
            string method,
            string url
        )
        {
            var result = string.Empty;

            try
            {
                if (keyInfo == null) return result;
                if (string.IsNullOrWhiteSpace(keyInfo.Name)) return result;
                if (string.IsNullOrWhiteSpace(keyInfo.PrivateKey))
                    return result;
                
                if (string.IsNullOrWhiteSpace(method)) return result;
                if (method.AreAnyLettersLowercase()) return result;
                if (string.IsNullOrWhiteSpace(url)) return result;

                if (PrivateKeyProvider.CurrentPrivateKey == null)
                    PrivateKeyProvider.Load();

                result = JwtTokenGenerator.GenerateFor(
                    PrivateKeyProvider.CurrentPrivateKey, method, url
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
        /// Gets a <c>JSON Web Token (JWT)</c> value given the specified
        /// <paramref name="method" /> and request <paramref name="url" />.
        /// </summary>
        /// <param name="method">
        /// (Required.) A <see cref="T:System.String" /> that contains
        /// the particular HTTP method, say, for example, <c>GET</c>, <c>PUT</c>, or
        /// <c>POST</c> that is in use for the current request, in all-uppercase letters.
        /// </param>
        /// <param name="url">
        /// (Required.) A <see cref="T:System.String" /> containing the
        /// path and query of a request, e.g., <c>/v2/accounts?expand=all</c>.
        /// </param>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> that contains the JWT
        /// that is to be used; otherwise, the <see cref="F:System.String.Empty" /> value
        /// is returned.
        /// </returns>
        [return: NotLogged]
        public static string GetJWT(string method, string url)
        {
            var result = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(method)) return result;
                if (method.AreAnyLettersLowercase()) return result;
                if (string.IsNullOrWhiteSpace(url)) return result;

                if (PrivateKeyProvider.CurrentPrivateKey == null)
                    PrivateKeyProvider.Load();

                result = JwtTokenGenerator.GenerateFor(
                    PrivateKeyProvider.CurrentPrivateKey, method, url
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
    }
}