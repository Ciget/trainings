using System;
namespace Algo.BFS
{
    public class FindNearestPathToZero
    {
        Queue<int[]> _queue = new Queue<int[]>();
        private int[][] _directions = new int[4][] {
            new int[] {-1,0 },
            new int[] {1,0 },
            new int[] {0,-1 },
            new int[] {0,1 }
        };


        public int[][] UpdateMatrix(int[][] mat)
        {
            int rowLength = mat.Length;
            int colLength = mat[0].Length;

            int[][] result = new int[rowLength][];
            for (int i = 0; i < rowLength; i++)
            {
                int[] row = new int[colLength];
                for (int j = 0; j < colLength; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        _queue.Enqueue(new int[] { i, j });
                        row[j] = 0;
                    }
                    else {
                        row[j] = int.MaxValue;
                    }
                }
                result[i] = row;
            }

            //run find nearest zero
            while (_queue.Count > 0)
            {
                var point = _queue.Dequeue();

                var m = point[0];
                var n = point[1];

                foreach (var direction in _directions)
                {
                    var nm = m + direction[0];
                    var nn = n + direction[1];

                    if (nm < 0 || nn < 0 || nm >= rowLength || nn >= colLength || result[nm][nn] <= mat[m][n] + 1)
                        continue;
                    
                    result[nm][nn] = result[m][n] + 1;
                    _queue.Enqueue(new int[] { nm, nn });
                  
                }
            }

            return result;
        }
    }
}

