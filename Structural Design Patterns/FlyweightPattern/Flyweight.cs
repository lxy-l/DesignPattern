namespace FlyweightPattern;

public class Flyweight
{
    private Car _sharedState;

    public Flyweight(Car car)
    {
        this._sharedState = car;
    }

    public void Operation(Car uniqueState)
    {
        string s = System.Text.Json.JsonSerializer.Serialize(this._sharedState);
        string u = System.Text.Json.JsonSerializer.Serialize(uniqueState);
        Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
    }
}