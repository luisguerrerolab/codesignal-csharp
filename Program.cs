using System;

namespace codesignal
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Started program...");
            var input = Console.ReadLine();
            var runner = new SmoothSailing();
            
            runner.SortByHeight(ConvertToIntArray(input));
        }

        static int[] ConvertToIntArray(string strArray)
        {
            return Array.ConvertAll(strArray.Split(','), int.Parse);
        }
    }
}
