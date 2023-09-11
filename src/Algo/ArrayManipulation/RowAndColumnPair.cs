namespace Algo.ArrayManipulation;

//2352. Equal Row and Column Pairs
public class RowAndColumnPair
{
    
    public int EqualPairs(int[][] grid)
    {
        int n = grid.Length;
        int resut = 0;
        
        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
            {
                bool match = true;

                for (int i = 0; i < n; i++)
                {
                    if (grid[r][i] != grid[i][c])
                    {
                        match = false;
                        break;
                    }
                }

                resut += match ? 1 : 0;
            }
        }

        return resut;
    }
}