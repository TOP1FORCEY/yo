using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp7
{
    class Program
    {
        static int PI = 3;
        static int S = 1;
        static int L = 1;
        static int R = 1;
        static void Main(string[] args)
        {
            R = Convert.ToInt32(Console.ReadLine());
            L = 2 * PI * R;
            Console.WriteLine("UR L IS");
            Console.WriteLine(L);
            S = PI * (S * S);
            Console.WriteLine("UR S IS");
            Console.WriteLine(S);
            Console.ReadKey();

        }
    }
}
