
namespace Algo.StringManipulation
{
    public class PalindromSolution
    {
        public bool IsPalindrome(String s)
        {
            var query = s.Where(Char.IsLetterOrDigit).Select(Char.ToLower);
            var arr = query.ToArray(); // Copy array returned from query
            Array.Reverse(arr); // Reverse arr to test palindrome
                                // Using string compare against query result and reversed result
            return new string(query.ToArray()) == new string(arr);
        }

        public string LongestPalindrome(string s)
        {
            if (String.IsNullOrEmpty(s)) return "";

            int start = 0, end = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int len1 = ExpandFromMiddle(s, i, i);
                int len2 = ExpandFromMiddle(s, i, i + 1);

                int longest = Math.Max(len1, len2);

                if (longest > end - start)
                {
                    start = i - (longest - 1) / 2;
                    end = i + longest / 2;
                }
            }

            return s.Substring(start, end - start + 1);
        }

        protected int ExpandFromMiddle(string input, int left, int right)
        {
            if (string.IsNullOrEmpty(input) || left > right) return 0;

            while (left >= 0 && right < input.Length && input[left] == input[right])
            {
                left--;
                right++;
            }

            return right - left - 1;
        }

        public string ShortestPalindrome(string s)
        {
            return "";
        }
    }
}
