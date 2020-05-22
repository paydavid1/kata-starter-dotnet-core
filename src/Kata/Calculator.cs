using System.Linq;

namespace Kata.Spec
{
    public class Calculator
    {
        public int Add(string n="")
        {
            if (string.IsNullOrEmpty(n))
                return 0;

            var arrayNumber = n.Split(new[] {',','\n'}) .Select(int.Parse);

            return arrayNumber.Sum();
        }
    }
}