using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int result = 2; result <= number; result++)
            {
                bool isPrime = true;
                for (int count = 2; count <= Math.Sqrt(result); count++)
                {
                    if (result % count == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{result} -> {isPrime}");
            }

            }

        }
    }
  
