using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string input = "Mary had a little lamb Little lamb, little lamb Mary had a little lamb It's fleece was white as snow";
        var result = FizzBuzzDetector.GetOverlappings(input);
        Console.WriteLine("Output String: " + result.OutputString);
        Console.WriteLine("Fizz Count: " + result.FizzCount);
        Console.WriteLine("Buzz Count: " + result.BuzzCount);
        Console.WriteLine("FizzBuzz Count: " + result.FizzBuzzCount);
    }
}
public class FizzBuzzDetector
{
    public static FizzBuzzOutput GetOverlappings(string input)
    {
        if (input == null) throw new ArgumentNullException(nameof(input));

        int FizzCount = 0;
        int BuzzCount = 0;
        int FizzBuzzCount = 0;
        string outputString = string.Empty;

        string[] words = input.Split(' ');
        int alphanumericCount = 0;
        foreach (string word in words)
        {
            if (IsAlphanumeric(word))
            {
                string replacmentWord = word;
                alphanumericCount++;

                if (alphanumericCount % 15 == 0)
                {
                    FizzBuzzCount++;
                    replacmentWord = "FizzBuzz";
                }
                else if (alphanumericCount % 3 == 0)
                {
                    FizzCount++;
                    replacmentWord = "Fizz";
                }
                else if (alphanumericCount % 5 == 0)
                {
                    BuzzCount++;
                    replacmentWord = "Buzz";
                }

                outputString += replacmentWord + ' ';
            }
            else
            {
                outputString += word;
            }
        }

        return new FizzBuzzOutput(outputString, FizzCount, BuzzCount, FizzBuzzCount);
    }
    public static bool IsAlphanumeric(string word)
    {
        return Regex.IsMatch(word, @"\w+");
    }
}

public record FizzBuzzOutput(string OutputString, int FizzCount, int BuzzCount, int FizzBuzzCount);