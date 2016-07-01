using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            if (IsPrime(n))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        static public bool IsPrime(int num)
        {
            int boundary = (int) Math.Floor(Math.Sqrt(num));
            if (num == 0 || num == 1) return false;
            if (num == 2) return true;
            for (int i = 2; i <= boundary; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
