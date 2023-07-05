using System;

namespace StrategyPattern;

public class Two : Strategy
{
    public void Method(string option)
    {
        Console.WriteLine("执行策略2");
    }
}