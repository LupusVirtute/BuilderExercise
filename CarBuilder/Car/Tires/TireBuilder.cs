namespace Tire;

public class TireBuilder
{
    private Tire tire;

    public TireBuilder()
    {
        tire = new Tire();
    }

    public TireBuilder SetType(TireType type)
    {
        tire.Type = type;
        return this;
    }

    public TireBuilder SetPrice(decimal price)
    {
        tire.Price = price;
        return this;
    }

    public TireBuilder SetCompanyName(string companyName)
    {
        tire.CompanyName = companyName;
        return this;
    }

    public Tire Build()
    {
        return tire;
    }
}
