using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation;

public class Sudoku36Test
{
    private char[][] board = new char[9][];
    private Sudoku36 _engine = new Sudoku36();
    
    [Fact]
    public void ShouldBeValid()
    {
        board[0] = new[] {'5','3','.','.','7','.','.','.','.'};
        board[1] = new[] {'6','.','.','1','9','5','.','.','.'};
        board[2] = new[] {'.','9','8','.','.','.','.','6','.'};
        board[3] = new[] {'8','.','.','.','6','.','.','.','3'};
        board[4] = new[] {'4','.','.','8','.','3','.','.','1'};
        board[5] = new[] {'7','.','.','.','2','.','.','.','6'};
        board[6] = new[] {'.','6','.','.','.','.','2','8','.'};
        board[7] = new[] {'.','.','.','4','1','9','.','.','5'};
        board[8] = new[] {'.','.','.','.','8','.','.','7','9'};

        _engine.IsSudokuValid36(board).Should().BeTrue();
    }
    
    [Fact]
    public void ShouldBeFalse()
    {
        board[0] = new[] {'8','3','.','.','7','.','.','.','.'};
        board[1] = new[] {'6','.','.','1','9','5','.','.','.'};
        board[2] = new[] {'.','9','8','.','.','.','.','6','.'};
        board[3] = new[] {'8','.','.','.','6','.','.','.','3'};
        board[4] = new[] {'4','.','.','8','.','3','.','.','1'};
        board[5] = new[] {'7','.','.','.','2','.','.','.','6'};
        board[6] = new[] {'.','6','.','.','.','.','2','8','.'};
        board[7] = new[] {'.','.','.','4','1','9','.','.','5'};
        board[8] = new[] {'.','.','.','.','8','.','.','7','9'};

        _engine.IsSudokuValid36(board).Should().BeFalse();
    }
}