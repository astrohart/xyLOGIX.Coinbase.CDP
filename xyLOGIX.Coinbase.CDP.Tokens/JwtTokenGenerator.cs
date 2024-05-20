using PostSharp.Patterns.Diagnostics;
using xyLOGIX.Coinbase.CDP.Tokens.Interfaces;

namespace xyLOGIX.Coinbase.CDP.Tokens
{
    /// <summary>
    /// Generates so-called <c>JSON Web Tokens</c> for use on the
    /// <c>Coinbase (Retail)</c> or the <c>Coinbase (Advanced Trade)</c> trading
    /// platform(s).
    /// </summary>
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static JwtTokenGenerator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected JwtTokenGenerator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:xyLOGIX.Coinbase.CDP.Tokens.Interfaces.IJwtTokenGenerator" />
        /// interface.
        /// </summary>
        public static IJwtTokenGenerator Instance { get; } =
            new JwtTokenGenerator();
    }
}