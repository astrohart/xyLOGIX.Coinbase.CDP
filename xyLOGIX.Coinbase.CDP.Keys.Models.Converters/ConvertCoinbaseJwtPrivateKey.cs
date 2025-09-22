using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Threading;
using System;
using System.Globalization;
using xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Coinbase.CDP.Keys.Models.Converters
{
    /// <summary>
    /// Exposes static methods that are to be used in order to serialize and
    /// deserialize <c>Coinbase CDP Private Key</c> data to/from JSON.
    /// </summary>
    [ExplicitlySynchronized]
    public static class ConvertCoinbaseJwtPrivateKey
    {
        /// <summary>
        /// Reference to an instance of
        /// <see cref="T:Newtonsoft.Json.JsonSerializerSettings" /> that specifies JSON
        /// configuration settings for the conversion operation.
        /// </summary>
        private static readonly JsonSerializerSettings Settings;

        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the
        /// <see
        ///     cref="T:xyLOGIX.Coinbase.CDP.Keys.Models.Converters.ConvertCoinbaseJwtPrivateKey" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static ConvertCoinbaseJwtPrivateKey()
            => Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Formatting = Formatting.Indented,
                Converters =
                {
                    new IsoDateTimeConverter
                    {
                        DateTimeStyles =
                            DateTimeStyles.AssumeUniversal
                    }
                }
            };

        /// <summary>
        /// Parses the specified <paramref name="json" /> content and, if successful,
        /// initializes an instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <param name="json">(Required.) String containing the JSON content to be parsed.</param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey" />
        /// interface whose properties are initialized from the JSON provided, or a
        /// <see langword="null" /> reference if an error occurred.
        /// </returns>
        [return: NotLogged]
        public static ICoinbaseJwtPrivateKey FromJson([NotLogged] string json)
        {
            ICoinbaseJwtPrivateKey result = default;

            try
            {
                if (string.IsNullOrWhiteSpace(json)) return result;

                result =
                    JsonConvert.DeserializeObject<CoinbaseJwtPrivateKey>(
                        json, Settings
                    );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }

        /// <summary>
        /// Serializes an instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey" />
        /// interface to JSON and returns this data in the form of a
        /// <see cref="T:System.String" />.
        /// </summary>
        /// <param name="data">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey" />
        /// interface that represents the data which is to be serialized.
        /// </param>
        /// <returns>
        /// If successful, this method returns a <see cref="T:System.String" />
        /// that contains the JSON content equivalent to the object passed.
        /// </returns>
        /// <remarks>
        /// If the <paramref name="data" /> parameter is passed a
        /// <see langword="null" /> reference, then the
        /// <see cref="F:System.String.Empty" /> value is returned.
        /// </remarks>
        [return: NotLogged]
        public static string ToJson([NotLogged] ICoinbaseJwtPrivateKey data)
        {
            var result = string.Empty;

            try
            {
                if (data == null) return result;

                result = JsonConvert.SerializeObject(data, Settings);
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