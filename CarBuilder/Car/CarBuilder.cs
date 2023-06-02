using Chair;
using Engine;
using Lacquer;
using SteeringWheel;
using Tire;

namespace Car;
public class CarBuilder
{
    private Car car;

    public CarBuilder()
    {
        car = new Car();
    }

    public CarBuilder SetEngine(Action<EngineBuilder> engineBuilderAction)
    {
        EngineBuilder engineBuilder = new EngineBuilder();
        engineBuilderAction(engineBuilder);
        car.Engine = engineBuilder.Build();
        return this;
    }

    public CarBuilder SetChair(Action<ChairBuilder> chairBuilderAction)
    {
        ChairBuilder chairBuilder = new ChairBuilder();
        chairBuilderAction(chairBuilder);
        car.Chair = chairBuilder.Build();
        return this;
    }

    public CarBuilder SetLacquer(Action<LacquerBuilder> lacquerBuilderAction)
    {
        LacquerBuilder lacquerBuilder = new LacquerBuilder();
        lacquerBuilderAction(lacquerBuilder);
        car.Lacquer = lacquerBuilder.Build();
        return this;
    }

    public CarBuilder SetTires(Action<TireBuilder> tireBuilderAction)
    {
        TireBuilder tireBuilder = new TireBuilder();
        tireBuilderAction(tireBuilder);
        car.Tires = tireBuilder.Build();
        return this;
    }
    public CarBuilder SetSteeringWheel(Action<SteeringWheelBuilder> steeringWheelBuilderAction)
    {
        SteeringWheelBuilder steeringWheelBuilder = new SteeringWheelBuilder();
        steeringWheelBuilderAction(steeringWheelBuilder);
        car.SteeringWheel = steeringWheelBuilder.Build();
        return this;
    }

    public CarBuilder SetPrice(decimal price)
    {
        car.Price = price;
        return this;
    }

    public Car Build()
    {
        return car;
    }
}