namespace CodeSamples;

public class CollectionExpressions
{
    public void DeclareCollectionExpressions()
    {
        int[] numbers = [1,2,3,4,5];
        List<string> names = ["Binh", "Doan", "Cuong"];
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}
