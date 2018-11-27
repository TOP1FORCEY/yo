using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static int a = 1;
        static void Main(string[] args)
        {
            a = Convert.ToInt32(Console.ReadLine());
            if (a >= 1000)
            {
                a = a / 1000;
                Console.Write(a);
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
