using System.Runtime.Serialization;

namespace Domain.Shared.FunnelLevels
{
    [Serializable]
    internal class FunnelLevelMustHaveNameException : Exception
    {
        public FunnelLevelMustHaveNameException()
        {
        }

        public FunnelLevelMustHaveNameException(string? message) : base(message)
        {
        }

        public FunnelLevelMustHaveNameException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected FunnelLevelMustHaveNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}