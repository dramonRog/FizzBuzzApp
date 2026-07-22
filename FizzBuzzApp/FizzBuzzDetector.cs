using System.Text;

namespace FizzBuzzApp
{
    public class FizzBuzzDetector
    {
        public FizzBuzzResult getOverlappings(string input)
        {
            if (input == null || input.Length < 7 || input.Length > 100)
            {
                throw new ArgumentException("Input can't be null or input length must be in range (7, 100)");
            }

            int wordCount = 0;
            int replacementsCount = 0;
            StringBuilder replacedText = new StringBuilder();
            StringBuilder currentWord = new StringBuilder();

            void ProcessWord()
            {
                if (currentWord.Length == 0)
                {
                    return;
                }

                if (currentWord.ToString().Any(char.IsLetterOrDigit))
                {
                    wordCount++;
                    string word = GetWord(wordCount, ref replacementsCount);
                    replacedText.Append(word == "" ? currentWord.ToString() : word);
                }
                else
                {
                    replacedText.Append(currentWord.ToString());
                }

                currentWord.Clear();
            }

            foreach (char c in input)
            {
                if (c == ' ' || c == '\n')
                {
                    ProcessWord();
                    replacedText.Append(c);
                }
                else
                {
                    currentWord.Append(c);
                }
            }

            ProcessWord();

            return new FizzBuzzResult
            {
                OutputString = replacedText.ToString(),
                Count = replacementsCount
            };
        }

        private string GetWord(int currentWordNumber, ref int replacementsCount)
        {
            if (currentWordNumber % 5 != 0 && currentWordNumber % 3 != 0)
            {
                return string.Empty;
            }

            replacementsCount++;

            if (currentWordNumber % 15 == 0)
            {
                return "FizzBuzz";
            }

            return currentWordNumber % 3 == 0 ? "Fizz" : "Buzz";
        }
    }
}