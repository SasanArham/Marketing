using Domain.Base;

namespace Domain.Shared.FunnelLevels
{
    public class FunnelLevel : ValueObject
    {
        public string Name { get; private set; }
        public Color Color { get; private set; }

        public FunnelLevel(string name, Color color)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new FunnelLevelMustHaveNameException();
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new FunnelLevelMustHaveNameException();
            }
            Name = name;
            Color = color;
        }


        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            yield return Color;
        }
    }
}
