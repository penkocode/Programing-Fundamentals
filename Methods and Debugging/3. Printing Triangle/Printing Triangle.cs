namespace _3.Printing_Triangle
{
    using System;
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);

        }
        public static void PrintColums(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write($"{col} ");
            }

            Console.WriteLine();
        }

        public static void PrintTriangle(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                PrintColums(row);
            }
            for (int row = n - 1; row >= 1; row--)
            {
                PrintColums(row);
            }
        }
    }
}

