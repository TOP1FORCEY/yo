using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a <= 0)
            {
                a = a * -1;
            }
            else
            {
                a = a * 1;
            }
            Console.WriteLine("сума");
            int s = a + b;
            Console.WriteLine(s);
            Console.WriteLine("разность");
            int d = a - b;
            Console.WriteLine(d);
            Console.WriteLine("произвидение");
            int f = a * b;
            Console.WriteLine(f);
            Console.WriteLine("частное");
            int g = a + b;
            Console.WriteLine(g);
            Console.ReadKey();
        }
    }
}
