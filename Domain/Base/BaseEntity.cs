using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Base
{
    public abstract class BaseEntity
    {
        public Guid ID { get; set; }

        private readonly List<DomainEvent> _DomainEvents = [];

        [NotMapped]
        public IReadOnlyCollection<DomainEvent> Events => _DomainEvents.AsReadOnly();

        public void AddDomainEvent(DomainEvent domainEvent)
        {
            _DomainEvents.Add(domainEvent);
        }

        public void ClearEventualConsistencyDomainEvents()
        {
            _DomainEvents.Clear();
        }
    }
}
