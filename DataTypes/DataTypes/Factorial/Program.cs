using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger facNo = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(CalcFactorial(facNo));         
        }

        private static BigInteger CalcFactorial(BigInteger num)
        {
            BigInteger result = 1;
            if (num == 0 || num == 1) return 1;
            else
            {
                for (BigInteger i = num; i >= 1; i--)
                {
                    result = result * i;  
                }
                return result;
            }
        }
    }
}
