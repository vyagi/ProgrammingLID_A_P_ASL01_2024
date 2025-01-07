namespace Utilities;

public static class StringUtilities
{
    public static int ToWords(string input) => input.Split(' ').Length;

    public static string ToSentence(string input) => input[..1].ToUpper() + input.ToLower()[1..];

    public static string ToCamelCase(string input)
    {
        var split = input.Split(' ');

        var result = split[0].ToLower();

        foreach (var element in split.Skip(1))
            result += ToSentence(element);

        return result;
    }
}