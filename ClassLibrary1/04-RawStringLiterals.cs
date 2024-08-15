namespace CodeSamples;

public class RawStringLiteral
{
    public static string longMessage =
"""
This is a long message.
It has serveral lines.
    Some are indented
            more than others.
Some should start at the first column.
Some has "quoted text" in them.
""";

    public RawStringLiteral()
    { }

    public void PrintLongMessage()
    {
        Console.WriteLine(longMessage);
    }
}