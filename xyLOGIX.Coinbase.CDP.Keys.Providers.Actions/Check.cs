using System;
using System.Text;
using xyLOGIX.Coinbase.CDP.Keys.Models.Converters;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Coinbase.CDP.Keys.Providers.Actions
{
    /// <summary>
    /// Exposes static methods to examine data.
    /// </summary>
    public static class Check
    {
        /// <summary>
        /// Checks whether the specified Coinbase CDP Private Key <paramref name="data" />
        /// is encrypted.
        /// </summary>
        /// <param name="data">
        /// (Required.) An array of <see cref="T:System.Byte" /> values
        /// that contains the possibly-encrypted data.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the data is not useful as-is; otherwise,
        /// <see langword="false" />, meaning the data is NOT encrypted.
        /// </returns>
        public static bool WhetherDataIsEncrypted(byte[] data)
        {
            var result = true;

            try
            {
                if (data == null) return result;
                if (data.Length == 0) return result;

                var contentToCheck = Encoding.UTF8.GetString(data);
                if (string.IsNullOrWhiteSpace(contentToCheck)) return result;

                var privateKey =
                    ConvertCoinbaseJwtPrivateKey.FromJson(contentToCheck);
                if (privateKey == null) return result;

                /*
                 * If we made it here, then the data is NOT encrypted.
                 */

                result = false;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = true;
            }

            return result;
        }
    }
}