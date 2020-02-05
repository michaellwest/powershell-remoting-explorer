using System;
using System.Runtime.Serialization;

namespace PSRemotingExplorer.Exceptions
{
    [Serializable]
    public class RemoteExecutionException : BaseException
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RemoteExecutionException" /> class.
        /// </summary>
        public RemoteExecutionException()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="RemoteExecutionException" /> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public RemoteExecutionException(string message)
            : base(message)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="RemoteExecutionException" /> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public RemoteExecutionException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="RemoteExecutionException" /> class.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Reading context.</param>
        protected RemoteExecutionException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}