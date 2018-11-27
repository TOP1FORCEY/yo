using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            a = a * a;
            b = b * b;
            int v = a * b;
            v = Convert.ToInt32(Math.Sqrt(5.25));
            Console.WriteLine(v);
            Console.ReadKey();
        }
    }
}
