namespace Maturita._13_Algorithm_Recursion
{
    public class Tester
    {
        public static bool TestFibonacci()
        {
            return RecursiveFunctions.GetFibonacci(7) == 13;
        }

        public static bool TestFactorial()
        {
            return RecursiveFunctions.GetFactorial(5) == 120;
        }
    }
}