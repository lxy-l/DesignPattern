using System;

namespace DecoratorPattern;

public class BMWCar : Car
{
    public void Run()
    {
        Console.WriteLine("宝马开车了");
    }
}