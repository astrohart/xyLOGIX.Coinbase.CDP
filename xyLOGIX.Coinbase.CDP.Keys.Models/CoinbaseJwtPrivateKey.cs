using Newtonsoft.Json;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces;

namespace xyLOGIX.Coinbase.CDP.Keys.Models
{
    /// <summary>
    /// Encapsulates the <c>name</c> and <c>privateKey</c> fields of the JSON object
    /// provided to users of the <c>Coinbase Developer Platform (CDP)</c> upon the
    /// creation of a new API key.
    /// </summary>
    public class CoinbaseJwtPrivateKey : ICoinbaseJwtPrivateKey
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the
        /// <see cref="T:xyLOGIX.Coinbase.CDP.Keys.Models.CoinbaseJwtPrivateKey" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static CoinbaseJwtPrivateKey() { }

        /// <summary>
        /// Creates a new instance of
        /// <see cref="T:xyLOGIX.Coinbase.CDP.Keys.Models.CoinbaseJwtPrivateKey" /> and
        /// returns a reference to it.
        /// </summary>
        [Log(AttributeExclude = true)]
        public CoinbaseJwtPrivateKey() { }

        /// <summary>
        /// Gets a <see cref="T:System.Guid" /> that distinguishes one instance of this
        /// object from another.
        /// </summary>
        [JsonIgnore]
        public Guid KeyId { get; } = Guid.NewGuid();

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that contains the name of the JWT
        /// private key.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that contains the private key --
        /// in PEM format.
        /// </summary>
        [JsonProperty("privateKey")]
        public string PrivateKey { get; set; }
    }
}    