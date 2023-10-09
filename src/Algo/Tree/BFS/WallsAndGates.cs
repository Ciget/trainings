using System;
using System.Reflection;

namespace Algo.BFS
{
    /// <summary>
    /// Task #286
    /// </summary>
    public class WallsAndGatesTask
    {
        private const int WALL = -1;
        private const int GATE = 0;
        private const int EMPTY = int.MaxValue;
        private Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();

        private List<Tuple<int, int>> DIRECTIONS = new List<Tuple<int, int>> {
            new Tuple<int, int>(1, 0),
            new Tuple<int, int>(-1, 0),
            new Tuple<int, int>(0, 1),
            new Tuple<int, int>(0, -1)
        };

        public void WallsAndGates(int[][] rooms)
        {
            if (rooms.Length == 0) return;

            int rowCount = rooms.Length;
            int colCount = rooms[0].Length;

            //add all gates to the queue
            for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                for (int colIndex = 0; colIndex < colCount; colIndex++)
                {
                    if (rooms[rowIndex][colIndex] == GATE)
                    {
                        queue.Enqueue(new Tuple<int, int>(rowIndex, colIndex));
                    }
                }
            }

            while (queue.Count > 0)
            {
                var element = queue.Dequeue();
                var r = element.Item1;
                var c = element.Item2;

                foreach (var dimention in DIRECTIONS)
                {
                    var newRow = r + dimention.Item1;
                    var newCol = c + dimention.Item2;

                    if (r < 0 || c < 0 || newRow < 0 || newCol>=colCount || newRow>=rowCount
                        || newCol < 0 || rooms[newRow][newCol] != EMPTY)
                    {
                        continue;
                    }

                    rooms[newRow][newCol] = rooms[r][c] + 1;

                    queue.Enqueue(new Tuple<int, int>(newRow, newCol));
                }
            }
        }
    }
}

