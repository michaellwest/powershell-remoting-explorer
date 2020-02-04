using System;
using System.Runtime.Serialization;

namespace PSRemotingExplorer.Exceptions
{
    [Serializable]
    public class TrustedHostMissingException : NaosWinRmBaseException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustedHostMissingException"/> class.
        /// </summary>
        public TrustedHostMissingException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrustedHostMissingException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public TrustedHostMissingException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrustedHostMissingException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public TrustedHostMissingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrustedHostMissingException"/> class.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Reading context.</param>
        protected TrustedHostMissingException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
