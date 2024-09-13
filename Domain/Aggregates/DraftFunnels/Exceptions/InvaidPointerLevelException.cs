using System.Runtime.Serialization;

namespace Domain.Aggregates.DraftFunnels.Exceptions
{
    [Serializable]
    internal class InvaidPointerLevelException : Exception
    {
        public InvaidPointerLevelException()
        {
        }

        public InvaidPointerLevelException(string? message) : base(message)
        {
        }

        public InvaidPointerLevelException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvaidPointerLevelException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}