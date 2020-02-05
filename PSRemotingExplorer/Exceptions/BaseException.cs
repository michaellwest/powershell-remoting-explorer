using System;
using System.Runtime.Serialization;

namespace PSRemotingExplorer.Exceptions
{
    [Serializable]
    public abstract class BaseException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseException" /> class.
        /// </summary>
        protected BaseException()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseException" /> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        protected BaseException(string message)
            : base(message)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseException" /> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        protected BaseException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseException" /> class.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Reading context.</param>
        protected BaseException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}