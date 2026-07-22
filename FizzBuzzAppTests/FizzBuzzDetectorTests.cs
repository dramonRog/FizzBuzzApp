using System;
using Xunit;

namespace FizzBuzzApp.Tests {
  public class FizzBuzzDetectorTests {
    private readonly FizzBuzzDetector _detector;

    public FizzBuzzDetectorTests() {
      _detector = new FizzBuzzDetector();
    }

    [Fact]
    public void GetOverlappings_NullInput_ThrowsArgumentException() {
      Assert.Throws<ArgumentException>(() => _detector.getOverlappings(null!));
    }

    [Fact]
    public void GetOverlappings_StringTooShort_ThrowsArgumentException() {
      string shortInput = "123456";

      Assert.Throws<ArgumentException>(() => _detector.getOverlappings(shortInput));
    }

    [Fact]
    public void GetOverlappings_StringTooLong_ThrowsArgumentException() {
      string longInput = new string('a', 101);

      Assert.Throws<ArgumentException>(() => _detector.getOverlappings(longInput));
    }

    [Fact]
    public void GetOverlappings_ExampleFromTask_ReturnsCorrectResult() {
      string input = "Mary had a little lamb" +
          "\nLittle lamb, little lamb" +
          "\nMary had a little lamb" +
          "\nIt's fleece was white as snow";

      string expectedOutput = "Mary had Fizz little Buzz" +
          "\nFizz lamb, little Fizz" +
          "\nBuzz had Fizz little lamb" +
          "\nFizzBuzz fleece was Fizz as Buzz";

      var result = _detector.getOverlappings(input);

      Assert.Equal(expectedOutput, result.OutputString);
      Assert.Equal(9, result.Count);
    }

    [Fact]
    public void GetOverlappings_WithPunctuation_ReplacesCorrectAlphanumericWords() {
      string input = "One two, three! four five. six seven";
      string expectedOutput = "One two, Fizz four Buzz Fizz seven";

      var result = _detector.getOverlappings(input);

      Assert.Equal(expectedOutput, result.OutputString);
      Assert.Equal(3, result.Count);
    }
  }
}