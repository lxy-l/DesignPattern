using System;

namespace DecoratorPattern;

public class BenzCar : Car
{
    public void Run()
    {
        Console.WriteLine("奔驰开车了");
    }
}