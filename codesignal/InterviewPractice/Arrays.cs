using System;
using System.Collections.Generic;
using System.Linq;

namespace codesignal
{
    public class Arrays
    {
        public char FirstNotRepeatingCharacter(string s)
        {
            Dictionary<char, int> letters = s
                .GroupBy(l => l)
                .ToDictionary(l => l.Key, l => l.Count());
            
            var singlesCount = letters.Count(item => item.Value.Equals(1));

            if (singlesCount >= 1)
                return letters.First(x => x.Value.Equals(1)).Key;

            return '_';
        }
    }
}