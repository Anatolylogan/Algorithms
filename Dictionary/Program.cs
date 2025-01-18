using Algorithms;

namespace Dictionary
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();
         
            var wordCount = Countingfrequency.CountWordFrequency(input);

            Console.WriteLine("Частота слов:");
            foreach (var entry in wordCount)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}