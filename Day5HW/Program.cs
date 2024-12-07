using System;

namespace Day5HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");

            int userInput = int.Parse(Console.ReadLine());

            for (int i = 1; i <= userInput; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    Console.WriteLine(i + " * " + j + " : " + i * j);
                }
                Console.WriteLine("\n");
            }

        }
    }
}
