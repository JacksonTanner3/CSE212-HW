public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public List<Feature> Features { get; set; } = new();
}

public class Feature
{
    public FeatureProperties Properties { get; set; } = new();
}

public class FeatureProperties
{
    public string Place { get; set; } = "";
    public double Mag { get; set; }
}