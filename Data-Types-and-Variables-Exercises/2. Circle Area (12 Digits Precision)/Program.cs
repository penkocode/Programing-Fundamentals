﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Circle_Area__12_Digits_Precision_
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            //The formula for Circle Area

            double result = Math.PI * r * r;

            Console.WriteLine("{0:f12}", result);

        }
    }
}
