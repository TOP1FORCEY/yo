using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp9
{
    class Program
    {
        static int a = 1;
        static void Main(string[] args)
        {
            a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int f = a * b;
            f = Convert.ToInt32(Math.Sqrt(5.25));
            
            
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
