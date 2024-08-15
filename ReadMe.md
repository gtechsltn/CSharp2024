
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
