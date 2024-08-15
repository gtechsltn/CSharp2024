
# 1 - File scoped namespace

Before
```
namespace CodeSamples
{
    public interface IShippingCalculator
    {
    }
}
```

After
```
namespace CodeSamples;
public interface IShippingCalculator
{
}
```

# 2 - Record struct

```
public record ResponseClass(long Id, string Name, string Description, int DefaultCapacity);

public record CreateRequestClass(string Name, string Description, int DefaultCapacity);

public record UpdateRequestClass(string Name, string Description, int DefaultCapacity);
```

# 3 - Global using directive

```
global using System.Linq;
```

# 4 - Raw string literals

```
string longMessage =
"""
This is a long message.
It has serveral lines.
    Some are indented
            more than others.
Some should start at the first column.
Some has "quoted text" in them.
""";
``` 

# 5 - List patterns

```
int[] numbers = { 1, 2, 3 };
Console.WriteLine(numbers is [1, 2, 3]); // => True
Console.WriteLine(numbers is [1, 2, 4]); // => False
Console.WriteLine(numbers is [1, 2, 3, 4]); // => False
Console.WriteLine(numbers is [0 or 1, <= 2, >= 3]); // => True
```

# 6 - Primary constructors

```
namespace CodeSamples;

public interface IDistanceCalculator
{
    Distance GetDistance();
}

public class Distance
{
}

public class DistanceCalculator : IDistanceCalculator
{
    public Distance GetDistance()
    {
        return new Distance();
    }
}

public class ExampleController(IDistanceCalculator service)
{
    public void TestPrimaryController()
    {
        service.GetDistance();
    }
}
```

# 7 - Collection Expressions

```
int[] numbers = [1, 2, 3, 4, 5];
List<string> names = ["Binh", "Doan", "Cuong"];
```