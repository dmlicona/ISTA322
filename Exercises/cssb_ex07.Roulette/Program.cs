
// Name: C# Exercise 8A
// Author: Denis Licona
// Date: 8 Mar 2020
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Exercise08a
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                new Utility();
                while (Console.KeyAvailable == false)
                    Thread.Sleep(250);
                cki = Console.ReadKey(true);
            }
            while (cki.Key != ConsoleKey.Spacebar);
        }
    }
}