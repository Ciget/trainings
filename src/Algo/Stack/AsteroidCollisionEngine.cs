namespace Algo.Stack;

public class AsteroidCollisionEngine
{
    //735. Asteroid Collision
    public int[] AsteroidCollision(int[] asteroids)
    {
        Stack<int> stack = new Stack<int>();

        foreach (int currentAsteroid in asteroids)
        {
            if (currentAsteroid > 0)
            {
                stack.Push(currentAsteroid);
                continue;
            }

            while (stack.Count>0 && stack.Peek()>0 && currentAsteroid<0 && stack.Peek()<Math.Abs(currentAsteroid))
            {
                stack.Pop();
            }

            if (stack.Count == 0 || stack.Peek()<0)
            {
                stack.Push(currentAsteroid);
            }
            else if (Math.Abs(currentAsteroid) == Math.Abs(stack.Peek()))
            {
                stack.Pop();
            }
        }

        return stack.Reverse().ToArray();
    }
}