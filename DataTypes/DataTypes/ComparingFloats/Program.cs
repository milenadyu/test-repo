using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double eps = 0.000001;

            double equal = Math.Abs(num1 - num2);
            //Console.WriteLine((double)num1);
            //Console.WriteLine((double)num2);
            //Console.WriteLine((double)equal);

            if (equal < eps) 
            {
                Console.WriteLine("True");
                //Console.WriteLine($"The difference {equal} < eps");
            }
            else if(equal > eps)
            {
               Console.WriteLine("False");
                //Console.WriteLine($"The difference of {equal} is too big");
            }
            else if(equal == eps)
            {
               Console.WriteLine("False");
                // Console.WriteLine($"Border case. The difference {equal} == eps. We consider the numbers are different.");
            }
        }
    }
}
