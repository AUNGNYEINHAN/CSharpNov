using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A  +  A    -> A, O
//A  +  B	   -> A, B, AB, O
//A  +  AB   -> A, B, AB
//A  +  O	   -> A, O
//B  +  B	   -> B, O
//B  +  AB   -> A, B, AB
//B  +  O	   -> B, O
//AB +  AB  -> A, B, AB
//AB +  O   -> A, B
//O  +  O	   -> O

namespace Day2HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your father's blood type : ");
            String fatherBType = Console.ReadLine().ToUpper();
            Console.WriteLine("Type your mother's blood type : ");
            String motherBType = Console.ReadLine().ToUpper();
            Console.WriteLine("Your Child's possible Blood Groups are : ");




            

            if (fatherBType == "AB" || motherBType == "AB")
            {
                Console.WriteLine("A");
                Console.WriteLine("B");

                if (fatherBType != "O" && motherBType != "O")
                {
                    Console.WriteLine("AB");
                }

            }
            else
            {
               
                //must print if both of them not AB
                Console.WriteLine(fatherBType);

                //no need to print again if both same
                if(fatherBType != motherBType)
                {
                    Console.WriteLine(motherBType);
                    if (fatherBType != "O" && motherBType != "O")
                    {
                        Console.WriteLine("O");
                        Console.WriteLine("AB");
                    }
                    

                }
                else
                {
                    //no need to print again if fat.. is O already
                    if (fatherBType != "O")
                    {
                        Console.WriteLine("O");
                    }
                }

              


            }

        }
    }
}
