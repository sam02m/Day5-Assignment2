using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if else loop
            int age = 19;
            if (age <= 18)
            {
                Console.WriteLine("You can eligible");
            }
            else
            {
                Console.WriteLine("You will be not eligible");
            }

            //for loop
            Console.WriteLine("\n");
            for (int i = 0; i < 10; i++)
                Console.WriteLine(i);

            //Foreach loop
            Console.WriteLine("\n");
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            //While loop
            Console.WriteLine("\n");
            int number = 0;
            while (number < 5)
            {
                Console.WriteLine(number);
                number++;
            }

            //do while loop
            Console.WriteLine("\n");
            int i1 = 0;

            do
            {
                Console.WriteLine("i1 = {0}", i1);
                i1++;

            } while (i1 < 5);

            //break statement
            Console.WriteLine("\n");
            for (int j = 0; j < 10; j++)
            {
                if (j == 4)
                {
                    break;
                }
                Console.WriteLine(j);
            }

            //
            Console.WriteLine("\n");
            for (int k = 0; k < 10; k++)
            {
                if (k == 4)
                {
                    continue;
                }
                Console.WriteLine(k);
            }
        }
    }
}
