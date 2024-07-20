using PostSharp.Patterns.Diagnostics;
using xyLOGIX.Coinbase.CDP.Tokens.Interfaces;

namespace xyLOGIX.Coinbase.CDP.Tokens.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:xyLOGIX.Coinbase.CDP.Tokens.Interfaces.IJwtTokenGenerator" />
    /// interface.
    /// </summary>
    public static class GetJwtTokenGenerator
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed
        /// once only for the
        /// <see cref="T:xyLOGIX.Coinbase.CDP.Tokens.Factories.GetJwtTokenGenerator" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static GetJwtTokenGenerator() { }

        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:xyLOGIX.Coinbase.CDP.Tokens.Interfaces.IJwtTokenGenerator" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:xyLOGIX.Coinbase.CDP.Tokens.Interfaces.IJwtTokenGenerator" />
        /// interface.
        /// </returns>
        public static IJwtTokenGenerator SoleInstance()
            => JwtTokenGenerator.Instance;
    }
}