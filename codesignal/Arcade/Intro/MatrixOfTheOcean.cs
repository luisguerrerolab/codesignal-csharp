using System.Collections.Generic;

namespace codesignal
{
    class MatrixOfTheOcean
    {
        static int MatrixElementsSum(int[][] rooms)
        {
            // var rooms = new int[][] {
            //     new int[] {0, 1, 1, 2},
            //     new int[] {0, 5, 0, 0},
            //     new int[] {2, 0, 3, 3}
            // };

            var priceSum = 0;
            var hauntedColumns = new List<int>();

            for (var y = 0; y < rooms.Length; y++) {
                for (var x = 0; x < rooms[y].Length; x++) {
                    if (hauntedColumns.FindIndex(c => c == x) >= 0)
                        continue;

                    if (rooms[y][x] == 0) {
                        hauntedColumns.Add(x);
                        continue;
                    }

                    priceSum += rooms[y][x];
                }
            }

            return priceSum;
        }
    }
}