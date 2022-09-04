using System;
using System.Xml.Linq;

namespace Algo.Stack
{
    /// <summary>
    /// Task #739
    /// </summary>
    public class DailyTemperaturesTask
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            int len = temperatures.Length;
            var answers = new int[len];

            Stack<Tuple<int, int>> _temp = new Stack<Tuple<int, int>>();

            for (int index = 0; index < len; index++)
            {
                int currentTemp = temperatures[index];
                while (_temp.Count > 0 && _temp.Peek().Item2<currentTemp)
                {
                    var element = _temp.Pop();
                    if (element.Item2 < currentTemp)
                    {
                        answers[element.Item1] = index - element.Item1;
                    }
                }

                _temp.Push(new Tuple<int, int>(index, temperatures[index]));
            }

            return answers;
        }
    }
}

