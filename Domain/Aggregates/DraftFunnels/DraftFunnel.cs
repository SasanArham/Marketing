using Domain.Aggregates.DraftFunnels.Exceptions;
using Domain.Base;
using Domain.Shared;
using Domain.Shared.FunnelLevels;

namespace Domain.Aggregates.DraftFunnels
{
    public class DraftFunnel : AggregateRoot
    {
        public string Name { get; private set; }

        public void ChangeName(string name)
        {
            EnforceInvariants(name);
            Name = name;
        }

        public Color Color { get; private set; }

        public void ChangeColor(Color color)
        {
            Color = color;
        }

        public LinkedList<FunnelLevel> Levels { get; set; } = [];

        public DraftFunnel(string name)
        {
            ID = Guid.NewGuid();
            EnforceInvariants(name);
            Name = name;
        }

        public DraftFunnel(string name, Color color)
        {
            ID = Guid.NewGuid();
            EnforceInvariants(name);
            Color = color;
            Name = name;
        }

        private void EnforceInvariants(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new FunnelMustHaveNameException();
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new FunnelMustHaveNameException();
            }
        }

        public void AddLevel(FunnelLevel level)
        {
            ArgumentNullException.ThrowIfNull(nameof(level));
            Levels.AddLast(level);
        }

        public void DeleteLevel(FunnelLevel level)
        {
            Levels.Remove(level);
        }

        public void MoveLevelAfter(FunnelLevel target, FunnelLevel pointerlevel)
        {
            var node = Levels.Find(pointerlevel);
            if (node is null)
            {
                throw new InvaidPointerLevelException("Cannot determine level index, the pointer level was not found in this funnel");
            }
            Levels.Remove(target);
            Levels.AddAfter(node, target);
        }

        public void MoveLevelBefore(FunnelLevel target, FunnelLevel pointerlevel)
        {
            var node = Levels.Find(pointerlevel);
            if (node is null)
            {
                throw new InvaidPointerLevelException("Cannot determine level index, the pointer level was not found in this funnel");
            }
            Levels.Remove(target);
            Levels.AddBefore(node, target);
        }

        public void DelteAllLevels()
        {
            Levels = [];
        }
    }
}
