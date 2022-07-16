namespace Algo.ArrayManipulation;

public class PascalTriangle118
{
    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> result = new List<IList<int>> {new List<int>(){1}};

        for (int i = 1; i < numRows; i++)
        {
            List<int> newRow = new List<int>(){1};
            var prevRow = result[i - 1];

            for (int j = 1; j < i; j++)
            {
                newRow.Add(prevRow[j-1] + prevRow[j]);
            }

            newRow.Add(1);
            result.Add(newRow);
        }

        return result;
    }
}