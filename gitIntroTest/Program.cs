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

            Console.Read();
        }

        private static void showVersion()
        {
            Console.WriteLine("Version : " + VERSION);
        }
    }
}
