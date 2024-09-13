using MediatR;

namespace Domain.Base
{
    public abstract record DomainEvent : INotification
    {
    }
}
