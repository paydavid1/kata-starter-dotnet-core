namespace Kata.Spec
{
    public class Calculator
    {
        public int Add(string n="")
        {
            if (string.IsNullOrEmpty(n))
                return 0;
            
            return int.Parse(n);
        }
    }
}