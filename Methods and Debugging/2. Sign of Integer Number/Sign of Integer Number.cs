namespace _2.Sign_of_Integer_Number
{
    using System;
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            PrintIntNumber(number);
        }

        public static void PrintIntNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
