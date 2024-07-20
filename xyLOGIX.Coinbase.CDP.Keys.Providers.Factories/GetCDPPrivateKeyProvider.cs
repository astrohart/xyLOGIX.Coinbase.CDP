using PostSharp.Patterns.Diagnostics;

namespace xyLOGIX.Coinbase.CDP.Keys.Providers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:xyLOGIX.Coinbase.CDP.Keys.Providers.ICDPPrivateKeyProvider" />
    /// interface.
    /// </summary>
    public static class GetCDPPrivateKeyProvider
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the
        /// <see
        ///     cref="T:xyLOGIX.Coinbase.CDP.Keys.Providers.Factories.GetCDPPrivateKeyProvider" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static GetCDPPrivateKeyProvider() { }

        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:xyLOGIX.Coinbase.CDP.Keys.Providers.ICDPPrivateKeyProvider" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:xyLOGIX.Coinbase.CDP.Keys.Providers.ICDPPrivateKeyProvider" />
        /// interface.
        /// </returns>
        public static ICDPPrivateKeyProvider SoleInstance()
            => CDPPrivateKeyProvider.Instance;
    }
}