using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static int a = 1;
        static void Main(string[] args)
        {
            a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a >= b)
            {
                b = a / b;
                Console.Write(b);
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Sorry, your number do not exist");
                Console.ReadKey();
            }
        }
    }
