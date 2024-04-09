using System;

namespace Lab10Recursion
{
    // Method to calculate the sum of all nunbers from n to m recursively
    public class Program
    {
        public static int SumFromToM(int n, int m)
        {
            if (n > m)
            {
                return 0;
            }
            else
            {
                return n + SumFromToM(n + 1, m);
            }
        }

        // Methodo to print out how many times a number can be evenly divided by 2
        public static int DivisionByTwo(int number)
        {
            if (number % 2 != 0)
            {
                return 0;
            }
            else
            {
                return 1 + DivisionByTwo (number / 2);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Addition");
            Console.WriteLine("Enter number n: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter number m: ");
            int m = Int32.Parse(Console.ReadLine());
            Console.WriteLine(SumFromToM(n, m));

            Console.WriteLine("\nDivision");
            Console.WriteLine("Enter your number: ");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Total number of divisions: {DivisionByTwo(number)}");
        }
    }
}
