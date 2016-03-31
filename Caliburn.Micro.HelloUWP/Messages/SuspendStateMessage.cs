using Windows.ApplicationModel;

namespace Caliburn.Micro.HelloUWP.Messages
{
    /// <summary>
    /// Class SuspendStateMessage.
    /// </summary>
    public class SuspendStateMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SuspendStateMessage"/> class.
        /// </summary>
        /// <param name="operation">The operation.</param>
        public SuspendStateMessage(SuspendingOperation operation)
        {
            this.Operation = operation;
        }

        /// <summary>
        /// Gets the operation.
        /// </summary>
        /// <value>The operation.</value>
        public SuspendingOperation Operation { get; }
    }
}
