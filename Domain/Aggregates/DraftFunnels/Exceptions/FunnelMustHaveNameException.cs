using System.Runtime.Serialization;

namespace Domain.Aggregates.DraftFunnels.Exceptions
{
    [Serializable]
    internal class FunnelMustHaveNameException : Exception
    {
        public FunnelMustHaveNameException()
        {
        }

        public FunnelMustHaveNameException(string? message) : base(message)
        {
        }

        public FunnelMustHaveNameException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected FunnelMustHaveNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}