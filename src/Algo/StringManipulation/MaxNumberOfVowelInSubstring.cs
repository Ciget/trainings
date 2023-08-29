
namespace Algo.StringManipulation
{
    //1456. Maximum Number of Vowels in a Substring of Given Length
    public class MaxNumberOfVowelInSubstring
    {
        public int MaxVowels(string s, int k)
        {
            if (k == 0 || s.Length == 0) return 0;

            int cntVowel = 0;

            for (int i = 0; i <= s.Length-k; i++)
            {
                int vowel = 0;
                for (int j = i; j < i+k; j++)
                {
                    if (IsVowel(s[j]))
                    {
                        vowel++;
                    }
                }

                if (vowel > cntVowel)
                {
                    cntVowel = vowel;
                    if (cntVowel == k) return cntVowel;
                }
            }

            return cntVowel;
        }

        private bool IsVowel(char c)
        {
            char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            return vowels.Any(v => v == c);
        }
    }
}
