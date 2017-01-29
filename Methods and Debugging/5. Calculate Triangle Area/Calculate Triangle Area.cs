using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = TrinagleArea(width, height);
            Console.WriteLine(area);
        }

        public static double TrinagleArea(double widht, double height)
        {
            return widht * height / 2;
        }
    }
}
