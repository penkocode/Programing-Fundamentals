namespace Test
{
    using System;

    public class Testing
    {
        public static void Main()

        {
            TestingMethod();
        }

        public static void TestingMethod()
        {


        }
        public static int GetMultipleOfEvensAndOdds(int number)
        {
            return Math.Abs(GetSumOfEvenDigits(number) * GetSumOfOddDigits(number));
        }

        public static int GetSumOfOddDigits(int number)
        {
            var result = 0;
            foreach (var symbol in number.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 == 1)
                {
                    result += digit;
                }
            }
            return result;
        }

        public static int GetSumOfEvenDigits(int number)
        {
            return 1;
        }
    }
}
