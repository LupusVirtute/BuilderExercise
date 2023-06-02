namespace SteeringWheel;

public class SteeringWheelBuilder
{
    private SteeringWheel steeringWheel;

    public SteeringWheelBuilder()
    {
        steeringWheel = new SteeringWheel();
    }

    public SteeringWheelBuilder SetIsSportSteeringWheel(bool isSportSteeringWheel)
    {
        steeringWheel.IsSportSteeringWheel = isSportSteeringWheel;
        return this;
    }

    public SteeringWheelBuilder SetIsNormal(bool isNormal)
    {
        steeringWheel.IsNormal = isNormal;
        return this;
    }

    public SteeringWheelBuilder SetPrice(decimal price)
    {
        steeringWheel.Price = price;
        return this;
    }

    public SteeringWheel Build()
    {
        return steeringWheel;
    }
}
