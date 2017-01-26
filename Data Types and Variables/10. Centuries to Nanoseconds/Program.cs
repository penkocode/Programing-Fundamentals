using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());

            var Years = 100 * centuries;
            var Days = (int)(365.2422 * Years);
            decimal Hours = Days * 24;
            decimal Minutes = Hours * 60M;
         

            Console.WriteLine($"{centuries} centuries = {Years} years = {Days} days = {Hours} hours = {Minutes} minutes = ");



        }
    }
}
