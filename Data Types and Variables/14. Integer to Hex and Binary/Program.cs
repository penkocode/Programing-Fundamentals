using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {

           
            int n = int.Parse(Console.ReadLine());
             //hex
            String hexNumber = n.ToString("X");

            Console.WriteLine(hexNumber);
             // bin
            int stringToconvert;
            string result = string.Empty;
            while (n > 0)
            {
                stringToconvert = n % 2;
                n /= 2;
                result = stringToconvert.ToString() + result;
            }
                         //result
                 Console.WriteLine(result);
        }
    }
}
