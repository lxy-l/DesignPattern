using System;

namespace DecoratorPattern;

/// <summary>
/// 自动驾驶装饰类
/// </summary>
public class AutoCarDecorator : CarDecorator
{
    public AutoCarDecorator(Car car) : base(car)
    {
    }

    public override void Run()
    {
        base.Run();
        AutoRun();
    }

    private void AutoRun()
    {
        Console.WriteLine("开启自动驾驶模式");
    }
}