namespace Algo.ArrayManipulation;

public class Sudoku36
{
    public bool IsSudokuValid36(char[][] board)
    {
        int n = 9;

        HashSet<char>[] boxes = new HashSet<char>[n];
        HashSet<char>[] rows = new HashSet<char>[n];
        HashSet<char>[] cols = new HashSet<char>[n];

        for (int i = 0; i < n; i++)
        {
            boxes[i] = new HashSet<char>();
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (board[i][j] == '.') continue;

                if (rows[i].Contains(board[i][j])) return false;
                else rows[i].Add(board[i][j]);
                
                if (cols[j].Contains(board[i][j])) return false;
                else cols[j].Add(board[i][j]);

                int idx = (i / 3) * 3 + j / 3;
                if (boxes[idx].Contains(board[i][j])) return false;
                else boxes[idx].Add(board[i][j]);
            }
        }

        return true;
    }
}