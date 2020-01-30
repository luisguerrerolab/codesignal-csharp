using System;
using System.Collections.Generic;
using System.Linq;

namespace codesignal
{
    public class SmoothSailing
    {
        static string[] AllLongestStrings()
        {
            var inputArray = new string[] { "a", "abc", "cbd", "zzzzzz", "a", "abcdef", "asasa", "aaaaaa" };
            var longest = new List<string> { inputArray[0] };

            for (var i = 0; i < inputArray.Length; i++) {
                if (inputArray[i].Length == longest.Last().Length && !inputArray[i].Equals(longest.Last())) {
                    System.Console.WriteLine($"Added: {inputArray[i]}");
                    longest.Add(inputArray[i]);
                }

                if (inputArray[i].Length > longest.Last().Length) {
                    System.Console.WriteLine($"Replaced: {inputArray[i]}");
                    longest = new List<string> { inputArray[i] };
                }
            }

            return longest.ToArray();
        }

        public int[] SortByHeight(int[] a)
        {
            var people = a.Where(x => x > -1).ToList();

            people.Sort();

            var row = new List<int>();
            foreach (int elm in a) {
                if (elm == -1) {
                    row.Add(-1);
                    continue;
                }

                row.Add(people.First());
                people.RemoveAt(0);
            }

            return row.ToArray();
        }

        public string ReverseInParentheses(string inputString)
        {
            while (inputString.Length > 0) {
                var open = inputString.LastIndexOf('(');

                if (open == -1)
                    break;

                var closed = inputString.IndexOf(')', open, inputString.Length - open);

                var normal = inputString.Substring(open + 1, (closed - open) - 1).ToString();
                if (!string.IsNullOrEmpty(normal))
                {
                    var reverse = new string(normal.Reverse().ToArray());
                    inputString = inputString.Replace(normal, reverse);
                }

                inputString = inputString.Remove(open, 1);
                inputString = inputString.Remove(closed - 1, 1);
            }

            return inputString;
        }

        public int[] AlternatingSums(int[] a)
        {
            var weightTeam1 = 0;
            var weightTeam2 = 0;

            for (var i = 0; i < a.Length; i++) {
                if (i % 2 == 0)
                    weightTeam1 += a[i];
                else
                    weightTeam2 += a[i];
            }

            return new int[] {weightTeam1, weightTeam2};
        }
    }
}