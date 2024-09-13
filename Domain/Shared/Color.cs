using Domain.Base;

namespace Domain.Shared
{
    public class Color : ValueObject
    {
        public int R { get; private set; }
        public int G { get; private set; }
        public int B { get; private set; }

        public Color(int r, int g, int b)
        {
            if (r < 0 || r > 255)
            {
                throw new NotValidColorCodeException("Color codes must be ar 0-255 range");
            }
            if (g < 0 || g > 255)
            {
                throw new NotValidColorCodeException("Color codes must be ar 0-255 range");
            }
            if (b < 0 || b > 255)
            {
                throw new NotValidColorCodeException("Color codes must be ar 0-255 range");
            }
            R = r;
            G = g;
            B = b;
        }

        public string Code()
        {
            return $"{R}{G}{B}";
        }



        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return R;
            yield return G;
            yield return B;
        }
    }
}

public class NotValidColorCodeException : Exception
{
    public NotValidColorCodeException(string message) : base(message)
    {

    }
}
