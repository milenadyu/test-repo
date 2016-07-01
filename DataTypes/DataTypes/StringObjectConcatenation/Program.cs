using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringObjectConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            var helloworld = hello + " " + world;

            //Console.WriteLine(helloworld);

            string res = helloworld;

            Console.WriteLine(res);
        }
    }
}
