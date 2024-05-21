using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces;
using xyLOGIX.Coinbase.CDP.Tokens.Interfaces;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Coinbase.CDP.Tokens
{
    /// <summary>
    /// Generates so-called <c>JSON Web Tokens</c> for use on the
    /// <c>Coinbase (Retail)</c> or the <c>Coinbase (Advanced Trade)</c> trading
    /// platform(s).
    /// </summary>
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        public string GenerateFor(ICoinbaseJwtPrivateKey key)
        {
            var result = string.Empty;

            try
            {
                // TODO: Add the code that may potentially throw an exception here
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }
            
            return result;
        }
        
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