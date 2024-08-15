namespace CodeSamples;

public class ListPatterns
{
    public void DeclareAndUseListPatterns()
    {
        int[] numbers = { 1, 2, 3 };
        Console.WriteLine(numbers is [1, 2, 3]); // => True
        Console.WriteLine(numbers is [1, 2, 4]); // => False
        Console.WriteLine(numbers is [1, 2, 3, 4]); // => False
        Console.WriteLine(numbers is [0 or 1, <= 2, >= 3]); // => True
    }
}