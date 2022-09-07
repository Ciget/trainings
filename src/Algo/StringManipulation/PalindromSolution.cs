using System;
using System.Text;

namespace Algo.StringManipulation
{
    public class PalindromSolution
    {
        public bool IsPalindrome(String s)
        {
            var query = s.Where(c => Char.IsLetterOrDigit(c)).Select(c => Char.ToLower(c));
            var arr = query.ToArray(); // Copy array returned from query
            Array.Reverse(arr); // Reverse arr to test palindrome
                                // Using string compare against query result and reversed result
            return new string(query.ToArray()) == new string(arr);
        }
    }
}
