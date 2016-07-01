using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }

        private static int Fib(int num)
        {
            int len = num;
            //int len = num - 1;//if Fibonacci row starts from 0
            int[] arr = new int[num + 1];
           // arr[0] = 0; //if Fibonacci row starts from 0
            arr[0] = 1;
            arr[1] = 1;
            for (int i = 2; i <= len; i++)
            {
                arr[i] = arr[i - 2] + arr[i - 1];
            }
            //To print all Fibonacci row for (int i = 0; i < len; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.WriteLine($"{len}, {arr[len]}");
            return  arr[len];
        }
    }
}
