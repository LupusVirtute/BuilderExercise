namespace Engine;

public class EngineBuilder
{
    private Engine engine;

    public EngineBuilder()
    {
        engine = new Engine();
    }

    public EngineBuilder SetType(EngineType type)
    {
        engine.Type = type;
        return this;
    }

    public EngineBuilder SetPower(int power)
    {
        engine.Power = power;
        return this;
    }

    public EngineBuilder SetCapacity(int capacity)
    {
        engine.Capacity = capacity;
        return this;
    }

    public EngineBuilder SetPrice(decimal price)
    {
        engine.Price = price;
        return this;
    }

    public Engine Build()
    {
        return engine;
    }
}
