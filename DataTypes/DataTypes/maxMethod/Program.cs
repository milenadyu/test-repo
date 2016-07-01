using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("{0}", Math.Max( (GetMax(num1, num2)), num3) );
        }

        private static int GetMax(int a, int  b)
        {
            int maxi = Math.Max(a,b); 
            return maxi;
        }
    }
}
