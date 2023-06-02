namespace Lacquer;

public class LacquerBuilder
{
    private Lacquer lacquer;

    public LacquerBuilder()
    {
        lacquer = new Lacquer();
    }

    public LacquerBuilder SetIsMetallic(bool isMetallic)
    {
        lacquer.IsMetallic = isMetallic;
        return this;
    }

    public LacquerBuilder SetIsNormal(bool isNormal)
    {
        lacquer.IsNormal = isNormal;
        return this;
    }

    public LacquerBuilder SetIsVeneered(bool isVeneered)
    {
        lacquer.IsVeneered = isVeneered;
        return this;
    }

    public LacquerBuilder SetPrice(decimal price)
    {
        lacquer.Price = price;
        return this;
    }

    public Lacquer Build()
    {
        return lacquer;
    }
}
