using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    class Program
    {
        static int r = 1;
        static int hohoh = 1;
        static void Main(string[] args)
        {

            hohoh = Convert.ToInt32(Console.ReadLine());
            r = hohoh * hohoh * hohoh;
            Console.WriteLine("UR V IS");
            Console.WriteLine(r);
            hohoh = 6 * (hohoh * hohoh);
            Console.WriteLine("UR S IS");
            Console.WriteLine(hohoh);
            Console.ReadKey();
        }

    }
}