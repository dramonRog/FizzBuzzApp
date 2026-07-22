using System;
using System.Linq;
using System.Text;

namespace FizzBuzzApp {
  /// <summary>
  /// Detector for replacing specific alphanumeric words with Fizz, Buzz, or FizzBuzz.
  /// </summary>
  public class FizzBuzzDetector {
    /// <summary>
    /// Processes the input string and replaces every 3rd word with "Fizz", 
    /// 5th with "Buzz", and 15th with "FizzBuzz".
    /// </summary>
    /// <param name="input">The input string (7 <= length <= 100).</param>
    /// <returns>A FizzBuzzResult containing the modified string and replacement count.</returns>
    /// <exception cref="ArgumentException">When the input string is null or not in range (7, 100).</exception>
    public FizzBuzzResult getOverlappings(string input) {
      if (input == null || input.Length < 7 || input.Length > 100) {
        throw new ArgumentException("Input can't be null or input length must be in range (7, 100)");
      }

      int wordCount = 0;
      int replacementsCount = 0;
      var replacedText = new StringBuilder();
      var currentWord = new StringBuilder();

      void ProcessWord() {
        if (currentWord.Length == 0) {
          return;
        }

        if (currentWord.ToString().Any(char.IsLetterOrDigit)) {
          wordCount++;
          string word = GetWord(wordCount);
          
          if (word != string.Empty) {
            replacementsCount++;
            replacedText.Append(word);
          } else {
            replacedText.Append(currentWord.ToString());
          }
        } else {
          replacedText.Append(currentWord.ToString());
        }

        currentWord.Clear();
      }

      foreach (char c in input) {
        if (c == ' ' || c == '\n') {
          ProcessWord();
          replacedText.Append(c);
        } else {
          currentWord.Append(c);
        }
      }

      ProcessWord();

      return new FizzBuzzResult {
        OutputString = replacedText.ToString(),
        Count = replacementsCount
      };
    }

    private string GetWord(int currentWordNumber) {
      if (currentWordNumber % 5 != 0 && currentWordNumber % 3 != 0) {
        return string.Empty;
      }

      if (currentWordNumber % 15 == 0) {
        return "FizzBuzz";
      }

      return currentWordNumber % 3 == 0 ? "Fizz" : "Buzz";
    }
  }
}