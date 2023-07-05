namespace DecoratorPattern;

/// <summary>
/// 装饰器基类
/// </summary>
public abstract class CarDecorator : Car
{
    protected Car Car;

    public CarDecorator(Car car)
    {
        Car = car;
    }

    public virtual void Run()
    {
        Car.Run();
    }
}