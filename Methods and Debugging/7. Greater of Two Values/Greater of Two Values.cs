namespace _7.Greater_of_Two_Values
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            if (input == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char resultLager = GetMax(first, second);
                Console.WriteLine(resultLager);
            }

            else if (input == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int resultLager = GetMax(first, second);
                Console.WriteLine(resultLager);
            }

            else
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string resultLager = GetMax(first, second);
                Console.WriteLine(resultLager);
            }
        }

        public static char GetMax(char first, char second)
        {
            char lager = (char)0x00;

            if (first >= second)
            {
                lager = first;
            }
            else
            {
                lager = second;
            }
            return lager;
        }

        public static int GetMax(int first, int second)
        {
            int lager = 0;
            if (first >= second)
            {
                lager = first;
            }
            else
            {
                lager = second;
            }
            return lager;
        }

        public static string GetMax(string first, string second)
        {
            string lager = string.Empty;
            if (first.CompareTo(second) >= 0)
            {
                lager = first;
            }

            else
            {
                lager = second;
            }

            return lager;
        }
    }
}
