using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            string choice;

            do
            {

                Console.WriteLine("Enter Number to find out table of the Number");

                num = int.Parse(Console.ReadLine());
                Console.WriteLine($"Table of {num} as follows");
                for (int i = 1; i <= 10; i++)

                {

                    Console.WriteLine($" {num} {i} = \t {(num * i)}");

                }

                Console.WriteLine("Do you wanna learn more \n If yes press y \n To Exit press any other key");
                choice = Console.ReadLine().ToLower();
            }
            while (choice=="y");

        }
    }
}
