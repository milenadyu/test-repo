using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertHexToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            double convtNum = Convert.ToInt32(num, 16);

            Console.WriteLine(convtNum);
        }
    }
}
