using System;
namespace CircleCiTestFunction
{
    public class AnotherCoveredClass
    {
        public AnotherCoveredClass()
        {
        }

        public float AddNumbers(float x, float y) => x + y;

        public float DivideNumbers(float x, float y)
        {
            if (y == 0) return 0;

            return x / y;
        }

        public string GetString(int x)
        {
            if (x < 10) return "Less than 10";

            if (x < 50) return "Less than 50";

            if (x < 100) return "Less than 100";

            return "Greater than 100";
        }
    }
}

