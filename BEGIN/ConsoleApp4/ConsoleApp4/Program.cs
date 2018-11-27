using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static float r = 3.14f;
        static float a = 0;
        static void Main(string[] args)
        {
            a = Convert.ToInt32(Console.ReadLine());
            a = a * r;
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
