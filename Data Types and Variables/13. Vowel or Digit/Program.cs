using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter the digit or symbol it the console

            char symbol = Convert.ToChar(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'o') || (symbol == 'e') || (symbol == 'i') || (symbol == 'u'))
            {
                //Write "vowel" if is true
                Console.WriteLine("vowel");
            }
            else if (symbol >= '0' && symbol <= '9')
            {
                //Write "digit" if is true
                Console.WriteLine("digit");
            }
            else
            {
                //Write "other" if is true
                Console.WriteLine("other");
            }
        }
    }
}
