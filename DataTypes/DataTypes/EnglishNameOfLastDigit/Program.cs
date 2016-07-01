using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintLastDigitAsWord(n);

        }

        private static void PrintLastDigitAsWord(int num)
        {
            int lastDigit = num % 10;
            if (lastDigit == 0) Console.WriteLine("zero");
            else
            {
                switch (lastDigit)
                {
                    case 1:
                    Console.WriteLine("one");
                    break;
                    case 2:
                    Console.WriteLine("two");
                    break;
                    case 3:
                    Console.WriteLine("three");
                    break;
                    case 4:
                    Console.WriteLine("four");
                    break;
                    case 5:
                    Console.WriteLine("five");
                    break;
                    case 6:
                    Console.WriteLine("six");
                    break;
                    case 7:
                    Console.WriteLine("seven");
                    break;
                    case 8:
                    Console.WriteLine("eight");
                    break;
                    case 9:
                    Console.WriteLine("nine");
                    break;
                    default:
                    Console.WriteLine("error");
                    break;
                }
            }
        }
    }
}
