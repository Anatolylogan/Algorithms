using System.Text.RegularExpressions;

namespace Algorithms
    {
        public class Countingfrequency
        {
            public static Dictionary<string, int> CountWordFrequency(string text)
            {
                var wordCount = new Dictionary<string, int>();

                string[] words = Regex.Split(text.ToLower(), @"\W+");

                foreach (var word in words)
                {
                    if (!string.IsNullOrEmpty(word))
                    {
                        if (wordCount.ContainsKey(word))
                        {
                            wordCount[word]++;
                        }
                        else
                        {
                            wordCount[word] = 1;
                        }
                    }
                }

                return wordCount;
            }
        }
    }




