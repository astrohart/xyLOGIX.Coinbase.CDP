using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Threading;
using System.Net.Http;
using xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces;

namespace xyLOGIX.Coinbase.CDP.Tokens.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed events, methods and properties of an object that
    /// generates <c>JSON Web Tokens</c> for use on the <c>Coinbase (Retail)</c> or
    /// <c>Coinbase (Advanced Trade)</c> trading platform(s).
    /// </summary>
    [Synchronized]
    public interface IJwtTokenGenerator
    {
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
        string GenerateFor(
            ICoinbaseJwtPrivateKey key,
            string method,
            string path
        );

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
        string GenerateFor(
            [NotLogged] string name,
            [NotLogged] string privateKey,
            HttpMethod method,
            string path
        );
    }
}