using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitIntroTest
{
    class Program
    {
        private const string VERSION = "1.1";

        static void Main(string[] args)
        {
            showVersion();
            Console.WriteLine("Very first bit of code");
            Console.WriteLine("My second bit of code");

            Console.WriteLine("My third bit of code");

            Console.WriteLine("Lots 1");
            Console.WriteLine("Lots 2");
            Console.WriteLine("Lots 3");
            Console.WriteLine("Lots 4");
            Console.WriteLine("Lots 5");

            Console.Read();
        }

        private static void showVersion()
        {
            Console.WriteLine("Version : " + VERSION);
        }
    }
}
