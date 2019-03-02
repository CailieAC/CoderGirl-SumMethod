using System;

namespace SumMethod
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");
            int numberInput = int.Parse(Console.ReadLine());
            int sum = Sum(numberInput);
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        // TODO: Create a method that returns the sum of all integer numbers up to and including given value. 
        // Use the equation (n * (n + 1)) / 2.
        public static int Sum(int numberInput)
        {
            int sum = 0;
            sum = (numberInput * (numberInput + 1)) / 2;
            return sum;
        }
    }
}
