using Alphaleonis.Win32.Filesystem;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Threading;
using xyLOGIX.Coinbase.CDP.Keys.Models.Converters;
using xyLOGIX.Coinbase.CDP.Keys.Models.Factories;
using xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces;
using xyLOGIX.Coinbase.CDP.Keys.Providers.Actions;
using xyLOGIX.Coinbase.CDP.Keys.Providers.Properties;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;
using xyLOGIX.Files.Secure.Actions;
using Read = xyLOGIX.Files.Secure.Actions.Read;

namespace xyLOGIX.Coinbase.CDP.Keys.Providers
{
    /// <summary>
    /// Methods and properties for loading, accessing, and saving the configuration.
    /// </summary>
    [Synchronized]
    public class CDPPrivateKeyProvider : ICDPPrivateKeyProvider
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static CDPPrivateKeyProvider() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected CDPPrivateKeyProvider() { }

        /// <summary>
        /// Gets or sets a reference to the instance of an object implementing the
        /// <see
        ///     cref="T:xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey" />
        /// interface that
        /// represents the currently-loaded private key.
        /// </summary>
        public ICoinbaseJwtPrivateKey CurrentPrivateKey { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:xyLOGIX.Coinbase.CDP.Keys.Providers.ICDPPrivateKeyProvider" />
        /// interface.
        /// </summary>
        public static ICDPPrivateKeyProvider Instance { [DebuggerStepThrough] get; } =
            new CDPPrivateKeyProvider();

        /// <summary>
        /// Gets the fully-qualified pathname of the default configuration file.
        /// </summary>
        public string SecretsFilePathname { [DebuggerStepThrough] get; } =
            Resources.CoinbaseCdpSecretFileLocation;

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
        [return: NotLogged]
        public ICoinbaseJwtPrivateKey Load(string pathname = "")
        {
            var result = CurrentPrivateKey =
                MakeNewCoinbaseJwtPrivateKey.FromScratch();

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Load: Determining which filename is to be used for loading API secrets..."
                );

                var filenameToUse = Does.FileExist(pathname)
                    ? pathname
                    : SecretsFilePathname;

                // Dump the variable filenameToUse to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "CDPPrivateKeyProvider.Load: filenameToUse = '*****'"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** INFO: Checking whether the file '*****' exists..."
                );

                if (!Does.FileExist(filenameToUse))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The file '*****' does not exist.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"CDPPrivateKeyProvider.Load: Result = {result}"
                    );

                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Load: *** SUCCESS *** Located the file '*****' on the disk.  Reading its contents..."
                );

                /*
                 * Now, the code splits into two paths.
                 *
                 * (a) If the file is already plaintext, and in JSON format, then
                 * simply read its contents as is, and deserialize them.
                 * (b) If the file cannot be processed as in (a), then assume that
                 * it must be encrypted, and then decrypt it.
                 *
                 */

                var fileBytes = File.ReadAllBytes(filenameToUse);

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Load: Checking whether the variable 'fileBytes' has a null reference for a value or a zero length..."
                );

                // Check to see if the variable, fileBytes, is null. If it is, send an error to the log file and quit, returning from the method.
                if (fileBytes == null || fileBytes.Length == 0)
                {
                    // the variable fileBytes is required to have a valid object reference.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "CDPPrivateKeyProvider.Load: *** ERROR ***  The 'fileBytes' variable has a null reference or a zero length.  Stopping."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"CDPPrivateKeyProvider.Load: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                // We can use the variable, fileBytes, because it's not set to a null reference.
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"CDPPrivateKeyProvider.Load: *** SUCCESS *** {fileBytes.Length} byte(s) obtained from the file.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Load: Checking whether the contents of file '*******' are encrypted..."
                );

                if (!Check.WhetherDataIsEncrypted(fileBytes))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        "CDPPrivateKeyProvider.Load: The data in the file '*******' is NOT encrypted.  Working with it as-is..."
                    );

                    var jsonContent = File.ReadAllText(filenameToUse);
                    if (string.IsNullOrWhiteSpace(jsonContent)) return result;

                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"CDPPrivateKeyProvider.Load: *** SUCCESS *** {jsonContent.Length} B of data were read from file '******'.  Deserializing it..."
                    );

                    result = ConvertCoinbaseJwtPrivateKey.FromJson(jsonContent);

                    DebugUtils.WriteLine(
                        result != null ? DebugLevel.Info : DebugLevel.Error,
                        result != null
                            ? "*** SUCCESS *** The private-key data has been deserialized successfully."
                            : "*** ERROR *** FAILED to deserialize the private-key data."
                    );

                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Load: Attempting to obtain the user's RSA private key..."
                );

                var privateKey = Read.PrivateKey(Resources.File_PrivateKeyPem);

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Load: Checking whether the variable 'privateKey' has a null reference for a value..."
                );

                // Check to see if the variable, privateKey, is null. If it is, send an error to the log file and quit, returning from the method.
                if (privateKey == null)
                {
                    // the variable privateKey is required to have a valid object reference.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "CDPPrivateKeyProvider.Load: *** ERROR ***  The 'privateKey' variable has a null reference.  Stopping."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"CDPPrivateKeyProvider.Load: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                // We can use the variable, privateKey, because it's not set to a null reference.
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Load: *** SUCCESS *** The 'privateKey' variable has a valid object reference for its value.  Using it for decryption..."
                );

                var decryptedContent = Decrypt.Data(fileBytes, privateKey);

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Load: Checking whether the 'decryptedContent' variable has a null reference for a value, or is blank..."
                );

                // Check to see if the required variable, decryptedContent, is null or blank. If it is, send an
                // error to the log file and quit, returning the default value of the result
                // variable.
                if (string.IsNullOrWhiteSpace(decryptedContent))
                {
                    // the variable decryptedContent is required.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "CDPPrivateKeyProvider.Load: *** ERROR *** The 'decryptedContent' variable has a null reference or is blank.  Stopping."
                    );

                    // log the result
                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"CDPPrivateKeyProvider.Load: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"CDPPrivateKeyProvider.Load: *** SUCCESS *** {decryptedContent.Length} B of decrypted content were obtained.  Deserializing it..."
                );

                result = CurrentPrivateKey =
                    ConvertCoinbaseJwtPrivateKey.FromJson(decryptedContent);
            }
            catch
            {
                result = MakeNewCoinbaseJwtPrivateKey.FromScratch();
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"CDPPrivateKeyProvider.Load: Result = {result}"
            );

            return result;
        }

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
        public void Save(
            ICoinbaseJwtPrivateKey privateKeyData = default,
            string pathname = ""
        )
        {
            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** INFO: Determining which filename is to be used for saving API secrets..."
                );

                var filenameToUse = string.IsNullOrWhiteSpace(pathname)
                    ? SecretsFilePathname
                    : pathname;

                // Dump the value of the 'filenameToUse' variable to the log.
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "CDPPrivateKeyProvider.Save: filenameToUse = '*****'"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Save: Checking whether the 'filenameToUse' variable has a null reference for a value, or is blank..."
                );

                // Check to see if the required variable, filenameToUse, is null or blank. If it is,
                // send an error to the log file and then stop the execution of this method.
                if (string.IsNullOrWhiteSpace(filenameToUse))
                {
                    // the variable filenameToUse is required.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "CDPPrivateKeyProvider.Save: *** ERROR *** The 'filenameToUse' variable has a null reference or is blank.  Stopping..."
                    );

                    return;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Save: *** SUCCESS *** The 'filenameToUse' variable is set to a non-blank string."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Save: Determining which data is to be saved..."
                );

                var dataToUse = privateKeyData ?? CurrentPrivateKey;

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"CDPPrivateKeyProvider.Save: dataToUse = {dataToUse}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Save: Checking whether the variable 'dataToUse' has a null reference for a value..."
                );

                // Check to see if the variable, dataToUse, is null. If it is, send an error to the log file and quit, returning from the method.
                if (dataToUse == null)
                {
                    // the variable dataToUse is required to have a valid object reference.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "CDPPrivateKeyProvider.Save: *** ERROR ***  The 'dataToUse' variable has a null reference.  Stopping."
                    );

                    // stop.
                    return;
                }

                // We can use the variable, dataToUse, because it's not set to a null reference.
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Save: *** SUCCESS *** The 'dataToUse' variable has a valid object reference for its value."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Save: Determining the folder to use for saving the data..."
                );

                var folder = Path.GetDirectoryName(filenameToUse);

                // Dump the variable folder to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"CDPPrivateKeyProvider.Save: folder = '{folder}'"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"CDPPrivateKeyProvider.Save: Creating the folder '{folder}' if it does not already exist..."
                );

                if (!Directory.Exists(folder))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"CDPPrivateKeyProvider.Save: The folder '{folder}' does not yet exist.  Creating it..."
                    );

                    Directory.CreateDirectory(folder);
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"CDPPrivateKeyProvider.Save: The folder '{folder}' exists."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Save: Overwriting the file '*****' if it already exists..."
                );

                if (Does.FileExist(filenameToUse))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        "CDPPrivateKeyProvider.Save: The file '*****' currently exists.  Deleting it..."
                    );

                    File.Delete(filenameToUse);
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Save: Ready to write data to the file '*****'."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Save: Converting the API secrets data to JSON format..."
                );

                var jsonData = ConvertCoinbaseJwtPrivateKey.ToJson(dataToUse);

                if (string.IsNullOrWhiteSpace(jsonData))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** No JSON data was produced from the conversion process.  Stopping..."
                    );

                    return;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"CDPPrivateKeyProvider.Save: *** SUCCESS *** {jsonData.Length} byte(s) of JSON data was produced by the serialization process."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Save: Attempting to read the user's RSA public key from the file '*****'..."
                );
                var publicKey = Read.PublicKey(Resources.File_PublicKeyPem);

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Save: Checking whether the variable 'publicKey' has a null reference for a value..."
                );

                // Check to see if the variable, publicKey, is null. If it is, send an error to the log file and quit, returning from the method.
                if (publicKey == null)
                {
                    // the variable publicKey is required to have a valid object reference.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "CDPPrivateKeyProvider.Save: *** ERROR ***  The 'publicKey' variable has a null reference.  Stopping."
                    );

                    // stop.
                    return;
                }

                // We can use the variable, publicKey, because it's not set to a null reference.
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Save: *** SUCCESS *** The 'publicKey' variable has a valid object reference for its value."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Save: Attempting to encrypt the API secret data so that it cannot be read..."
                );

                var encryptedBytes = Encrypt.StringData(jsonData, publicKey);

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Save: Checking whether the variable 'encryptedBytes' has a null reference for a value or a zero length..."
                );

                // Check to see if the variable, encryptedBytes, is null. If it is, send an error to the log file and quit, returning from the method.
                if (encryptedBytes == null || encryptedBytes.Length == 0)
                {
                    // the variable encryptedBytes is required to have a valid object reference.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "CDPPrivateKeyProvider.Save: *** ERROR ***  The 'encryptedBytes' variable has a null reference or a zero length.  Stopping."
                    );

                    // stop.
                    return;
                }

                // We can use the variable, encryptedBytes, because it's not set to a null reference.
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"CDPPrivateKeyProvider.Save: *** SUCCESS *** We have {encryptedBytes.Length} byte(s) of encrypted data.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CDPPrivateKeyProvider.Save: Writing the encrypted data to '*****'..."
                );

                File.WriteAllBytes(filenameToUse, encryptedBytes);
            }
            catch
            {
                //Ignored.
            }
        }
    }
}