using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static string a;
        static int hohoh = 1;
        static void Main(string[] args)
        {
            hohoh = Convert.ToInt32(Console.ReadLine());
            hohoh = hohoh * hohoh;
            Console.WriteLine("UR S IS");
            Console.WriteLine(hohoh);

      
            hohoh = hohoh + hohoh;
            Console.WriteLine("UR P  IS");
            Console.WriteLine(hohoh);

            Console.ReadKey();
        }
    }
}
