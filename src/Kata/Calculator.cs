using System;
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

            var negatives = arrayNumber.Where(x => x < 0);
            if (negatives.Any())
            {
                throw new Exception($"negatives not allowed: {negatives.First()}");
            }
            return arrayNumber.Sum();
        }
    }
}