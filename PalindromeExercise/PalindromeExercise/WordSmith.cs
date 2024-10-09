using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return false;
            }

            var normalizedWord = new string(word
                .Where(char.IsLetterOrDigit)
                .Select(char.ToLower)
                .ToArray());

            return normalizedWord.SequenceEqual(normalizedWord.Reverse().ToArray());
        }
    }
}
