using System;
namespace Algo.BFS
{
    public class FloodFillSolution
    {
        protected void dfs(int[][] image, int sr, int sc, int color, int newColor)
        {
            if (image[sr][sc] != color)
            {
                return;
            }

            image[sr][sc] = newColor;

            if (sr + 1 < image.Length) dfs(image, sr + 1, sc, color, newColor);
            if (sr - 1 >= 0) dfs(image, sr - 1, sc, color, newColor);
            if (sc + 1 < image[sr].Length) dfs(image, sr, sc + 1, color, newColor);
            if (sc - 1 >= 0) dfs(image, sr, sc - 1, color, newColor);
        }

        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            if (image[sr][sc] != color)
            {
                dfs(image, sr, sc, image[sr][sc], color);
            }
            return image;
        }
    }
}

