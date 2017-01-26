using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int letterOne = 0; letterOne < number; letterOne++)
            {
                for (int letterTwo = 0; letterTwo < number; letterTwo++)
                {
                    for (int letterThree = 0; letterThree < number; letterThree++)
                    {

                        Console.WriteLine("{0}{1}{2}",(char)('a' + letterOne), (char)('a' + letterTwo),(char)('a' + letterThree));
                    }

                }
            }
            
               
            }
            
        }
    }

