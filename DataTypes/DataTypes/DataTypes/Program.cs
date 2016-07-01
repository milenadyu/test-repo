using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte a = 0;
            //for (int i = 0; i < 260; i++)
            //{
            //    Console.WriteLine(a);
            //    a++;
            //}
            int a = 1000000;
            int b = 1000000;
            checked
            {
                Console.WriteLine(a * b);
            }
          //  Console.WriteLine(a);
        }
    }
}
