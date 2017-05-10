using System;
using Maturita._11_Qeue_Stack;

namespace Maturita
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Stack" + Tester.TestMyStack());
            Console.WriteLine("Qeue" + Tester.TestMyQeue());
            Console.WriteLine("Fibo" + _13_Algorithm_Recursion.Tester.TestFibonacci());
            Console.WriteLine("Factorial" + _13_Algorithm_Recursion.Tester.TestFactorial());

        }
    }
}