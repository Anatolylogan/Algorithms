using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class Countingfrequency
    {
        public Dictionary<string, int> CountWords(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Текст не может быть пустым или состоять только из пробелов.");
            }

            var words = input.ToLower()
            .Split(new[] { ' ', '\n', '\t', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

            var wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    wordCount[word] = wordCount.TryGetValue(word, out int count) ? count + 1 : 1;
                }
            }

            return wordCount;
        }
    }
}
