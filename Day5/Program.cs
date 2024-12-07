using System;
using System.Collections;

namespace Day5
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[1] = 1;
            numbers[2] = 5;


            int n = 0;
        ITC: if (n < 5)
            {
                Console.WriteLine(numbers[n]);
                n++;
                goto ITC;
            }


            ArrayList mydata = new ArrayList();
            mydata.Add(10);
            mydata.Add("sdafds");
            mydata.Add(10.34);
            mydata.Add(DateTime.Now);
            foreach (var res in mydata)
            {
                Console.WriteLine(res);
            }

            int a = 10, b = 20, c = 30;

            int*[] pointerArray = new int*[3];

            pointerArray[0] = (int*)a;
            pointerArray[1] = (int*)b;
            pointerArray[2] = (int*)c;

            foreach (var t in pointerArray)
            {
                Console.WriteLine((int)t);
            }


        }
    }
}
