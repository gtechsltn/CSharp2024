public record ResponseClass(long Id, string Name, string Description, int DefaultCapacity);
public record CreateRequestClass(string Name, string Description, int DefaultCapacity);
public record UpdateRequestClass(string Name, string Description, int DefaultCapacity);