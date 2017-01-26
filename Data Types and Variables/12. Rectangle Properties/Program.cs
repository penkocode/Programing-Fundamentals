using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input Rectangle Dimensions form Console

            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            // Calculation for perimeter

            double perimeter = 2 * (a + b);

            // Calculation for area

            double area = a * b;

            // Calculation for diagonal

            double diagonal = Math.Sqrt((a * a) + (b * b));

            //Print Result

            Console.WriteLine("{0}\n{1}\n{2}\n", perimeter, area, diagonal);
        }
    }
}
