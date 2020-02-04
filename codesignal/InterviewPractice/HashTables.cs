using System;
using System.Collections.Generic;
using System.Linq;

namespace codesignal
{
    public class HashTables
    {
        public string[][] GroupingDishes(string[][] dishes)
        {
            var grouped = dishes
                .ToList()
                .SelectMany(d => d.Skip(1).Take(d.Length - 1))
                .GroupBy(d => d)
                .Where(a => a.Count() >= 2)
                .OrderBy(a => a.Key, StringComparer.Ordinal);

            var byIngredient = new string[grouped.Count()][];

            var index = 0;
            foreach (var ingdt in grouped) {
                List<string> dishesForIngredient = new List<string>();

                for (var i = 0; i < dishes.Length; i++) {
                    if (Array.Find(dishes[i], e => e.Equals(ingdt.Key)) != null)
                        dishesForIngredient.Add(dishes[i][0]);
                }

                dishesForIngredient = dishesForIngredient.OrderBy(d => d, StringComparer.Ordinal).ToList();
                dishesForIngredient.Insert(0, ingdt.Key.Trim());

                byIngredient[index] = dishesForIngredient.ToArray();
                index++;
            }

            return byIngredient;
        }
    }
}