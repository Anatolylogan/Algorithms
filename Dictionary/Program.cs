using Algorithms;

namespace WordCounterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст для подсчёта частоты слов:");
            string input = Console.ReadLine();

            try
            {
                var wordCounter = new Countingfrequency();
                var wordFrequencies = wordCounter.CountWords(input);

                Console.WriteLine("Частота слов в тексте:");
                foreach (var entry in wordFrequencies)
                {
                    Console.WriteLine($"{entry.Key}: {entry.Value}");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
