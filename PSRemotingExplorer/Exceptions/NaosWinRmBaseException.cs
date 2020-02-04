using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PSRemotingExplorer.Exceptions
{
    [Serializable]
    public abstract class NaosWinRmBaseException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NaosWinRmBaseException"/> class.
        /// </summary>
        protected NaosWinRmBaseException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NaosWinRmBaseException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        protected NaosWinRmBaseException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NaosWinRmBaseException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        protected NaosWinRmBaseException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NaosWinRmBaseException"/> class.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Reading context.</param>
        protected NaosWinRmBaseException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
