using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp10
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            a = a * a;
            b = b * b;

            Console.WriteLine("сума");
            int s = a + b;
            Console.WriteLine(s);
            Console.WriteLine("разность");
            int y = a - b;
            Console.WriteLine(y);
            Console.WriteLine("произвидение");
            int f = a * b;
            Console.WriteLine(f);
            Console.WriteLine("частное");
            int g = a / b;
            Console.WriteLine(g);
            Console.ReadKey();
        }
    }
}
