namespace Algo.ArrayManipulation;

public class ReshapedMatrix566
{
    public int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        if (r * c != mat.Length * mat[0].Length) return mat;
        int [][] result = new int [r][];
       result[0] = new int[c];
       
       int ri=0, ci=0;
       for (int i = 0; i < mat.Length; i++)
       {
           for (int j = 0; j < mat[i].Length; j++)
           {
               if (ci == 0)
               {
                   result[ri] = new int[c];
               }

               result[ri][ci] = mat[i][j];
               ci++;
               if (ci == c)
               {
                   ci=0;
                   ri++;
               }
           }
           
       }
       return result;
    }
}