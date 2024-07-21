using System.Diagnostics;
using xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces;

namespace xyLOGIX.Coinbase.CDP.Keys.Providers
{
    /// <summary>
    /// Defines the publicly-exposed events, methods and properties of a provider of
    /// <c>Coinbase CDP</c> private key information.
    /// </summary>
    public interface ICDPPrivateKeyProvider
    {
        /// <summary>
        /// Gets or sets a reference to the instance of an object implementing the
        /// <see
        ///     cref="T:xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey" />
        /// interface that
        /// represents the currently-loaded private key.
        /// </summary>
        ICoinbaseJwtPrivateKey CurrentPrivateKey { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets the fully-qualified pathname of the default configuration file.
        /// </summary>
        string SecretsFilePathname { [DebuggerStepThrough] get; }

        /// <summary>
        /// Loads the configuration from the default configuration file, and stores the
        /// result in the values of the
        /// <see
        ///     cref="P:xyLOGIX.Coinbase.Tests.Config.Providers.CDPPrivateKeyProvider.CurrentSecrets" />
        /// property.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file from which the secrets are to be loaded.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey" />
        /// interface, whose
        /// properties have been initialized from the values in the application's default
        /// configuration file.
        /// </returns>
        /// <remarks>
        /// If the configuration file does not exist, or an I/O or other error occurs
        /// during the read operation, then the method returns a newly-constructed
        /// configuration object, all of whose properties are initialized to the default
        /// settings.
        /// </remarks>
        ICoinbaseJwtPrivateKey Load(string pathname = "");

        /// <summary>
        /// Saves the current configuration to the encrypted configuration file on the disk
        /// having the specified <paramref name="pathname" /> or having the default
        /// pathname (if none is provided).
        /// </summary>
        /// <param name="privateKeyData">
        /// (Optional.) Reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Coinbase.Tests.Config.Interfaces.ICoinbaseJwtPrivateKey" />
        /// interface that contains the secret information that is to be saved to a file
        /// having the specified <paramref name="pathname" />.
        /// </param>
        /// <param name="pathname">
        /// (Optional.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file to which the API secrets are to be saved.
        /// <para />
        /// The default value of this parameter is the <see cref="F:System.String.Empty" />
        /// value.
        /// <para />
        /// If the argument of this parameter is the <see cref="F:System.String.Empty" />
        /// value, then the default pathname is used.
        /// </param>
        /// <remarks>
        /// The file to which the <paramref name="privateKeyData" /> are saved is
        /// encrypted with a 512-bit RSA encryption algorithm.
        /// </remarks>
        void Save(
            ICoinbaseJwtPrivateKey privateKeyData = default,
            string pathname = ""
        );
    }
}