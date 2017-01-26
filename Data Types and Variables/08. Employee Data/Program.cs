using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            short age = short.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            var personalnumber = long.Parse(Console.ReadLine());
            var employeeNumber = long.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}\nLast name: {lastName}\nAge: {age}\nGender: {gender}\nPersonal ID: {personalnumber}\nUnique Employee number: {employeeNumber}");
        }
    }
}
