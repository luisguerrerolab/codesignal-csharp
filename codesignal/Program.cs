using System;

namespace codesignal
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Program is running...");

            // To test any exercise: instantiate class (world or section) and call function (level or topic)
            var runner = new SmoothSailing();

            var input = Console.ReadLine();
            while (!input.Equals("q")) {
                runner.ReverseInParentheses(input);
                input = Console.ReadLine();
            }
        }

        static int[] ConvertToIntArray(string strArray)
        {
            return Array.ConvertAll(strArray.Split(','), int.Parse);
        }
    }
}
