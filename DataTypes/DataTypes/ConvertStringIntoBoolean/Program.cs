using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringIntoBoolean
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool res = System.Convert.ToBoolean(input);//  Convert.ToBoolean(input);
            if (res)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
