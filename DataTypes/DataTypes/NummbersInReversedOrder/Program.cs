using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NummbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            //float num = float.Parse(Console.ReadLine());
            //if the number is integer only ReverseNumber(num);
            PrintReversedString(num);
        }

        private static void PrintReversedString(string s)
        {
            string str = new string(s.Reverse().ToArray());
            Console.WriteLine(str);
        }

        private static void ReverseNumber(int number)
        {
            int lastdigi;
            while (number > 0)
            {
                lastdigi = number % 10;
                Console.Write(lastdigi);
                number = number / 10;
            }
        }
        //void Main()
        //{
        //    double d = 12345.67;
        //    Console.WriteLine("Reversed: {0}", ReverseNumber(d));
        //}

        //double ReverseNumber(double number)
        //{
        //    return double.Parse(ReverseString(number.ToString()));
        //}

        //string ReverseString(string s)
        //{
        //    char[] charArray = s.ToCharArray();
        //    Array.Reverse(charArray);
        //    return new string(charArray);
        //}
    }
}
