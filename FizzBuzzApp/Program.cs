namespace FizzBuzzApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = "Mary had a little lamb\nLittle lamb, little lamb\nMary had a little lamb\nIt's fleece was white as snow";

            var detector = new FizzBuzzDetector();

            try
            {
                var result = detector.getOverlappings(input);

                Console.WriteLine("Output string: ");
                Console.WriteLine(result.OutputString);
                Console.WriteLine();
                Console.WriteLine($"count: {result.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}