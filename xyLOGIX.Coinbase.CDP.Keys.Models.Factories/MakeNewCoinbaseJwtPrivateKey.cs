using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces;

namespace xyLOGIX.Coinbase.CDP.Keys.Models.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see
    ///     cref="T:xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey" />
    /// interface, and returns references to
    /// them.
    /// </summary>
    public static class MakeNewCoinbaseJwtPrivateKey
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the
        /// <see
        ///     cref="T:xyLOGIX.Coinbase.CDP.Keys.Models.Factories.MakeNewCoinbaseJwtPrivateKey" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static MakeNewCoinbaseJwtPrivateKey() { }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey.PrivateKey" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey" />
        /// interface.
        /// </param>
        /// <param name="pem">
        /// (Required.) A <see cref="T:System.String" /> containing a private key in PEM
        /// format.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static ICoinbaseJwtPrivateKey AndPrivateKeyPem(
            this ICoinbaseJwtPrivateKey self,
            string pem
        )
        {
            if (self == null)
                throw new ArgumentNullException(nameof(self));

            self.PrivateKeyPem = pem;
            return self;
        }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey" />
        /// interface and returns a reference to
        /// it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey" />
        /// interface.
        /// </returns>
        public static ICoinbaseJwtPrivateKey FromScratch()
            => new CoinbaseJwtPrivateKey();

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey.Name" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey" />
        /// interface.
        /// </param>
        /// <param name="name">
        /// (Required.) A <see cref="T:System.String" /> bearing the name of the private
        /// key.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static ICoinbaseJwtPrivateKey HavingName(
            this ICoinbaseJwtPrivateKey self,
            string name
        )
        {
            if (self == null)
                throw new ArgumentNullException(nameof(self));

            self.Name = name;
            return self;
        }
    }
}