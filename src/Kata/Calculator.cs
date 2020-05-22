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

            string message = "";
            int cont = 0;

            foreach (int negative in negatives)
            {
                cont++;
                if (negatives.Count() == cont)
                {
                    message = message + negative.ToString();
                }
                else
                {
                    message = message + negative.ToString() + ", ";
                }

                

            }
            
            if (negatives.Any())
            {
                throw new Exception($"negatives not allowed: {message}");
            }
            return arrayNumber.Sum();
        }
    }
}