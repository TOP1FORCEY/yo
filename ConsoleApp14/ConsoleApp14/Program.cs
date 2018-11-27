using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp14
{
    class Program
    {
        static double S;
        static double L;
        static double PI = 3.14;
        static void Main(string[] args)
        {
            double R = Convert.ToDouble(Console.ReadLine());
            L = 2 * PI * R;
            S = PI * (R * R);
            Console.WriteLine("ur R was");
            Console.WriteLine(R);
            Console.WriteLine("so, ur L now");
            Console.WriteLine(L);
            Console.WriteLine("so, ur S now");
            Console.WriteLine(S);
            Console.ReadKey();    
        }
    }
}
