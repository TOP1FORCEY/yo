using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static int a = 1;
        static void Main(string[] args)
        {
            a = Convert.ToInt32(Console.ReadLine());
            if (a >= 100)
            {
                a = a / 100;
                Console.WriteLine(a);
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Sorry, your number do not exist");
                Console.ReadKey();
            }
        }

    }
}