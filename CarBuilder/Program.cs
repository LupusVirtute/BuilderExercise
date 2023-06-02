using Car;
using Chair;
using Engine;
using Tire;

public class Program
{
    public static void Main()
    {
        // Code creation mostly sponsored by ChatGPT
        // Corrected by me
        // I mostly told chat gpt what code contains
        // And how the final structure should look like
        var car = new CarBuilder()
            .SetEngine(engineBuilder =>
                engineBuilder.SetType(EngineType.Combustion)
                    .SetPower(200)
                    .SetCapacity(2000)
                    .SetPrice(10000)
            )
            .SetSteeringWheel(steeringWheelBuilder =>
                 steeringWheelBuilder.SetIsSportSteeringWheel(true)
                     .SetIsNormal(false)
                     .SetPrice(200)
             )
            .SetChair(chairBuilder =>
                chairBuilder.SetIsLeatherSeat(true)
                    .SetMaterial(ChairMaterial.Leather)
                    .SetPrice(500)
            )
            .SetLacquer(lacquerBuilder =>
                lacquerBuilder.SetIsMetallic(true)
                    .SetIsNormal(false)
                    .SetIsVeneered(false)
                    .SetPrice(1000)
            )
            .SetTires(tireBuilder =>
                tireBuilder.SetType(TireType.Summer)
                    .SetPrice(500)
                    .SetCompanyName("ABC Tires")
            )
            .SetPrice(20000)
            .Build();

        Console.WriteLine("Car Details:");
        Console.WriteLine("Engine Type: " + car.Engine.Type);
        Console.WriteLine("Engine Power: " + car.Engine.Power);
        Console.WriteLine("Engine Capacity: " + car.Engine.Capacity);
        Console.WriteLine("Engine Price: " + car.Engine.Price);
        Console.WriteLine("Chair IsLeatherSeat: " + car.Chair.IsLeatherSeat);
        Console.WriteLine("Chair Material: " + car.Chair.Material);
        Console.WriteLine("Chair Price: " + car.Chair.Price);
        Console.WriteLine("Lacquer IsMetallic: " + car.Lacquer.IsMetallic);
        Console.WriteLine("Lacquer IsNormal: " + car.Lacquer.IsNormal);
        Console.WriteLine("Lacquer IsVeneered: " + car.Lacquer.IsVeneered);
        Console.WriteLine("Lacquer Price: " + car.Lacquer.Price);
        Console.WriteLine("Tires Type: " + car.Tires.Type);
        Console.WriteLine("Tires Price: " + car.Tires.Price);
        Console.WriteLine("Tires Company Name: " + car.Tires.CompanyName);
        Console.WriteLine("Steering Wheel Price:" + car.SteeringWheel.Price);
        Console.WriteLine("Steering Wheel IsNormal:" + car.SteeringWheel.IsNormal);
        Console.WriteLine("Steering Wheel IsSport:" + car.SteeringWheel.IsSportSteeringWheel);
        Console.WriteLine("Car Price: " + car.Price);
        Console.WriteLine("Total Car Price: " + car.TotalPrice);
    }
}