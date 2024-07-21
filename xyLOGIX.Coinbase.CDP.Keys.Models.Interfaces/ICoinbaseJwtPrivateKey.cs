using System.Diagnostics;
using System;

namespace xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed events, methods and properties of an object that
    /// encapsulates the <c>name</c> and <c>privateKey</c> fields of the JSON object
    /// provided to users of the <c>Coinbase Developer Platform (CDP)</c> upon the
    /// creation of a new API key.
    /// </summary>
    public interface ICoinbaseJwtPrivateKey
    {
        /// <summary>
        /// Gets a <see cref="T:System.Guid" /> that distinguishes one instance of this
        /// object from another.
        /// </summary>
        Guid KeyId { [DebuggerStepThrough] get; }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that contains the name of the JWT
        /// private key.
        /// </summary>
        string Name { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that contains the private key --
        /// in PEM format.
        /// </summary>
        string PrivateKeyPem { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
    }
}