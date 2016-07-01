using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            var decimalToHex = Convert.ToString(input, 16).ToUpper();
            Console.WriteLine(decimalToHex);

            var decimalToBinary = Convert.ToString(input, 2).ToUpper();
            Console.WriteLine(decimalToBinary);
        }
    }
}
