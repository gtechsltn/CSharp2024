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