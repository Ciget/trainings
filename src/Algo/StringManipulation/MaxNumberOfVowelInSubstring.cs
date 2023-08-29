
namespace Algo.StringManipulation
{
    //1456. Maximum Number of Vowels in a Substring of Given Length
    public class MaxNumberOfVowelInSubstring
    {
        public int MaxVowels(string s, int k)
        {
            if (k == 0 || s.Length == 0) return 0;

            int cntVowel = 0, result=0;

            for (int i = 0; i < k; i++)
            {
                if (IsVowel(s[i]))
                {
                    cntVowel++;
                }
            }
            result = cntVowel;

            for (int i = k; i < s.Length; i++)
            {
                if (IsVowel(s[i]))
                {
                    cntVowel++;
                }

                if (IsVowel(s[i-k]))
                {
                    cntVowel--;
                }

                result = Math.Max(result, cntVowel);
                if (result == k) return result;
            }

            return result;
        }

        private bool IsVowel(char c)
        {
            char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            return vowels.Any(v => v == c);
        }
    }
}
