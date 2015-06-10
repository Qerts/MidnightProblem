using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GenUI testing terminal [Version 4.3.4860]");
            Console.WriteLine("Copyright(c) 2015 GenCorp Corporation. All rights reserved");
            Console.WriteLine("Booting please wait...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Done");
            Console.WriteLine("Welcome to UI testing terminal. Type 'help' for avaiable commands");
            Console.ReadKey();
        }
    }
}
