using System;

namespace Maturita._13_Algorithm_Recursion
{
    public class RecursiveFunctions
    {
        public static int GetFactorial(int n)
        {
            if (n == 1)
                return 1;
            return n * GetFactorial(n - 1);
        }

        public static int GetFibonacci(int n)
        {
            if (n == 0 || n == 1)
                return n;

            return GetFibonacci(n-1) + GetFibonacci(n-2);
        }
    }
}