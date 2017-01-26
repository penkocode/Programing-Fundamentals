using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 10;
            var newA = a * 2;
            var newB = b / 2;
            Console.WriteLine($"Before:\n a = {a}\n b = {b}\n After:\n a = {newA}\n b = {newB}\n");


        }
    }
}
