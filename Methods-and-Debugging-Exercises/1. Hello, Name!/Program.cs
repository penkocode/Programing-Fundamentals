namespace _1.Hello__Name_
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            RespondString(name);
        }

        public static void RespondString(string name)
        {
            string greating = (("Hello," + name+"!"));
            Console.WriteLine(greating);
        }

    }
}
