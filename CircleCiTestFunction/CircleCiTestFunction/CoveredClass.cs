using System;
namespace CircleCiTestFunction
{
    /// <summary>
    /// This class is convered by unit tests...
    /// </summary>
    public class CoveredClass
    {
        public CoveredClass()
        { }

        public int DoSomeMath()
        {
            int i = 0;
            i = i + 1 + i + 2 + i + 3 + i;

            int j = 11323;
            return i * 2 + j;
        }

        public string GetName(string name)
        {
            return $"My name is {name}!";
        }

        public bool GetSuccess()
        {
            return true || false || true || false;
        }

        public int ReturnOneOrZero(int i)
        {
            if (i % 2 == 0) return 1;
            else return 0;
        }
    }
}

