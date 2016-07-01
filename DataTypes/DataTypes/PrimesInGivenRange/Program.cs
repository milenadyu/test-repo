using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = Convert.ToInt32(Console.ReadLine());
            int end = Convert.ToInt32(Console.ReadLine());
            //for (int i = start; i <= end; i++)
            //{
            //    if (IsPrime(i)) Console.Write(i + " ");               
            //}
           // foreach (var item in FindPrimesInRange(start, end)) //!!! put comma after the last element 2, 3, 5, 7, 
            //{
                Console.Write( String.Join( ", ", FindPrimesInRange(start,end) ) );
            //}
        }
        static public bool IsPrime(int num)
        {
            int boundary = (int)Math.Floor(Math.Sqrt(num));
            if (num == 0 || num == 1) return false;
            if (num == 2) return true;
            for (int i = 2; i <= boundary; i++)
            {
                if (num % i == 0) return false;
            }
            return true;

        }
        static List<int> FindPrimesInRange(int start, int end)
        {
            List<int> listPrimes = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i)) listPrimes.Add(i);
            }
            return listPrimes;
        }
    }
}
