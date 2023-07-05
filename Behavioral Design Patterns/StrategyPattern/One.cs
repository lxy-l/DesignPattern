using System;

namespace StrategyPattern;

public class One : Strategy
{
    public void Method(string option)
    {
        Console.WriteLine("执行策略1");
    }
}