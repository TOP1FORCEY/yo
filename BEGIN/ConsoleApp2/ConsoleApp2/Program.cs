using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static string a;
        static int hahah = 1;
        static int hohah = 1;
        static int hohoh = 1;
        static void Main(string[] args)
        {
            hohoh = Convert.ToInt32(Console.ReadLine());
            hohah = Convert.ToInt32(Console.ReadLine());
            hahah = (hohah * hohoh) / 2;
            Console.WriteLine("UR hahah IS");
            Console.WriteLine(hahah);

            Console.ReadKey();
        }
    }
}

