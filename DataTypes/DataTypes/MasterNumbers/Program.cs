using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //string n = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (IsPalindrome(i.ToString()) && 
                    ContainsEvenDigit(i) && IsSumOfDigitsDividedBySeven(i))
                {
                    Console.WriteLine(i);
                }                    
            }
        }

        private static bool ContainsEvenDigit(int num)
        {
            bool containsEven = false;
           while(num != 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    containsEven = true;
                }
                num /= 10;
            }
            if (containsEven == true) return true;
            else return false;
        }

        private static bool IsSumOfDigitsDividedBySeven(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                int lastDigit = num % 10;
                sum += lastDigit;
                num = num / 10;
            }
            if (sum % 7 == 0) return true;
            else return false;

        }
        static bool IsPalindrome(string n)
        {
            for (int i = 0; i < n.Length / 2; i++)
            {
                if (n[i] != n[n.Length - 1 - i]) { return false; }
            }
            return true;
        }

        
    }
}
