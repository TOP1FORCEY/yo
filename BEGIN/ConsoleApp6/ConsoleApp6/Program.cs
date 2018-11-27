using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{

        class Program
        {
            static int S = 1;
            static int t = 1;
            static int V = 1;
            static int a = 1;
            static int b = 1;
            static void Main(string[] args)
            {

                
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                t = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("UR V IS");
                V = a * b * t;
                Console.WriteLine(V);
                S = 2 * (a * b + b * t + a * t);
                Console.WriteLine("UR S IS");
                Console.WriteLine(S);
                Console.ReadKey();
            }

        }
    
}

