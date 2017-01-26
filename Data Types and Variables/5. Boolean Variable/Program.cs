using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            var theWord = Boolean.Parse(Console.ReadLine());

            if (theWord==true)
            {
                Console.WriteLine("Yes");
            }
            else if (theWord==false)
            {
                Console.WriteLine("No");
            }
        
        }
    }
}
