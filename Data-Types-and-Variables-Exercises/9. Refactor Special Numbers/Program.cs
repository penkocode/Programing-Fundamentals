using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfdigits = 0; int num = 0; bool special = false;
            for (int digits = 1; digits <= number; digits++)
            {
                num = digits;
                while (digits > 0)
                {
                    sumOfdigits += digits % 10;
                    digits = digits / 10;
                }
                special = (sumOfdigits == 5) || (sumOfdigits == 7) || (sumOfdigits == 11);
                Console.WriteLine($"{num} -> {special}");
                sumOfdigits = 0;
                digits = num;
            }

        }
    }
}
