
#1 - File scoped namespace

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

#2 - Record struct

```
public record ResponseClass(long Id, string Name, string Description, int DefaultCapacity);

public record CreateRequestClass(string Name, string Description, int DefaultCapacity);

public record UpdateRequestClass(string Name, string Description, int DefaultCapacity);
```

#3 - Global using directive

```
global using System.Linq;
```

#4 - Raw string literals

```

```"# CSharp2024" 
