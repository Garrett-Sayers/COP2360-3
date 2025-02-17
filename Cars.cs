public class Car
{
    public string Model { get; }
    public readonly int Wheels = 4; // Readonly field

    public Car(string model)
    {
        Model = model;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"This car is a {Model} with {Wheels} wheels.");
    }
}
