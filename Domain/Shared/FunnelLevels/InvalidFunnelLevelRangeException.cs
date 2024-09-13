using System.Runtime.Serialization;

namespace Domain.Shared.FunnelLevels
{
    [Serializable]
    internal class InvalidFunnelLevelRangeException : Exception
    {
        public InvalidFunnelLevelRangeException()
        {
        }

        public InvalidFunnelLevelRangeException(string? message) : base(message)
        {
        }

        public InvalidFunnelLevelRangeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidFunnelLevelRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}