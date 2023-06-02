namespace Chair;

public class ChairBuilder
{
    private Chair chair;

    public ChairBuilder()
    {
        chair = new Chair();
    }

    public ChairBuilder SetIsLeatherSeat(bool isLeatherSeat)
    {
        chair.IsLeatherSeat = isLeatherSeat;
        return this;
    }

    public ChairBuilder SetMaterial(ChairMaterial material)
    {
        chair.Material = material;
        return this;
    }

    public ChairBuilder SetPrice(decimal price)
    {
        chair.Price = price;
        return this;
    }

    public Chair Build()
    {
        return chair;
    }
}
