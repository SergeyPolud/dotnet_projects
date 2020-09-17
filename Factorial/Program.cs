using System;

namespace Factorial
{
    class Program
    {
        public static int Factorial(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++) result *= i;
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter number to factorial it:");
            int num;
            while (!int.TryParse(Console.ReadLine(), out num)) Console.WriteLine("Do not write chars, only integers!");
            Console.WriteLine($"Factorial of {num}  =  {Factorial(num)}");
        }
    }
}
