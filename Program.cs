//Sillo Modise
//2021034521
//2022/04/21
//weekly test 06

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekly_test_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Display a multiplication table for the following positive integer:");
            int inumber = int.Parse(Console.ReadLine());
            Console.Write("Number of rows to display:");
            int iRows = int.Parse(Console.ReadLine());

            int n = 1;

            while (n <= iRows)
            {
                int imult = inumber * n;
                Console.WriteLine(n.ToString() + " X " + inumber.ToString() + " = " + imult.ToString());
                n++;
            }

            Console.WriteLine("\nPress any key to exit....");
            Console.ReadKey();
            

        }
    }
}
