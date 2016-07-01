using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //stringTest.All(char.IsDigit);
            bool inputDigit = input.All(char.IsDigit);
           // Console.WriteLine(inputDigit); //true=digit && false =not a digit

            bool inputLetter = input.All(char.IsLetter);//true = letter(s) && false = not letter(s)

            if (inputDigit)
            {
                Console.WriteLine("digit");
            }
            else if (inputLetter)
            {
                //Console.WriteLine("letters");
                bool isVowel = ((input == "a") || (input == "e") || (input == "i") ||
                    (input == "o") || (input == "u") );
                if (inputLetter == isVowel) Console.WriteLine("vowel");
                else Console.WriteLine("other");
            }
            else
            {
                Console.WriteLine("other");
            }
            //char vowels = 'a';

            
            
        }
    }
}
