namespace Car;
using Engine;
using Chair;
using Lacquer;
using Tire;
using SteeringWheel;
public class Car
{
    public Engine Engine { get; set; }
    public Chair Chair { get; set; }
    public Lacquer Lacquer { get; set; }
    public Tire Tires { get; set; }
    public SteeringWheel SteeringWheel { get; set; }
    public decimal Price { get; set; }
    public decimal TotalPrice => Price + SteeringWheel.Price + Lacquer.Price + Tires.Price + Chair.Price + Engine.Price;
}
