using System;
namespace Algo.ArrayManipulation
{
    public class DFS1
    {
        private void dfs(char[][] grid, int r, int c)
        {
            if (r<0 || c<0 || r>=grid.Length || c >=grid[r].Length || grid[r][c] == '0') {
                return;
            }

            grid[r][c] = '0';
            dfs(grid, r-1, c);
            dfs(grid, r +1, c);
            dfs(grid, r, c-1);
            dfs(grid, r, c+1);
        }

        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length==0)
            {
                return 0;
            }

            int numOfIslands = 0;

            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[r].Length; c++)
                {
                    if (grid[r][c] == '1')
                    {
                        numOfIslands++;
                        dfs(grid, r, c);
                    }
                }
            }

            return numOfIslands;
        }
    }
}

