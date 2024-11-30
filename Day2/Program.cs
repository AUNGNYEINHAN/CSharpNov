using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //Console.WriteLine("Enter your nationality :");
            //String nat = Console.ReadLine().ToLower();
            //Console.WriteLine("Enter your age ;");
            ////int age = int.Parse(Console.ReadLine());
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (nat == "mm" && age >= 18)
            //{
            //    Console.WriteLine("Can Vote");
            //}
            //else
            //{
            //    Console.WriteLine("Cant Vote");
            //}

            int marks = 65;

            if (marks >= 50)
            {
                if (marks >= 85)
                {
                    Console.WriteLine("Pass with D");
                }
                else if(marks >= 65){
                    Console.WriteLine("Pass with Credit");
                }
                else
                {
                    Console.WriteLine("Pass");
                }
            }
            else
            {
                Console.WriteLine("Stupid");
            }

            int month = 2, year = 2024;

            if (month == 2)
            {
                if (year % 4 == 0)
                {
                    Console.WriteLine("29 days");
                }
                else
                    Console.WriteLine("28 days");
            }
            else if (month == 4 || month == 6 || month == 9 || month ==11)
            {
                Console.WriteLine("30 days");
            }
            else
            {
                Console.WriteLine("31 days");
            }


            switch (month)
            {
                case 2:
                    Console.WriteLine("28 days");break;
                case 4: case 6: case 9: case 11:
                    Console.WriteLine("30 days"); break;
                default:
                    Console.WriteLine("31 days");break;
            }
        }
    }
}
