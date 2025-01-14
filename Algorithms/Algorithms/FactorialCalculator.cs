namespace Algorithms.Algorithms
{
    public static class FactorialCalculator
    {
        public static long CalculateFactorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("n must be a non-negative integer.");
            }

            if (n == 0 || n == 1)
            {
                return 1;
            }

            return n * CalculateFactorial(n - 1);
        }
    }
}
