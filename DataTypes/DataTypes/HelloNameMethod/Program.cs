using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloNameMethod
{
    class Program
    {

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintName(input);
            //PrintName;
        }
        private static void PrintName(string name)
            {
            Console.WriteLine($"Hello, {name}!");
            }
    }
}
