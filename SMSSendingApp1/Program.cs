﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSSendingApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI.ConsoleUserInterface.StartInteface();

            Console.WriteLine("Press any key to terminate program");
            Console.ReadKey();
        }
    }
}
