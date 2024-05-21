using PostSharp.Patterns.Diagnostics;
using xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces;

namespace xyLOGIX.Coinbase.CDP.Keys.Models.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey" /> interface, and returns references to
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
        /// Creates a new instance of an object that implements the
        /// <see cref="T:xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey" /> interface and returns a reference to
        /// it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey" /> interface.
        /// </returns>
        public static ICoinbaseJwtPrivateKey FromScratch()
            => new CoinbaseJwtPrivateKey();
    }
}