using System;
using System.Threading;

namespace SingletonPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        //WeatherForecast weather = WeatherForecast.GetInstance();
        //Console.WriteLine(weather.Date);
        //WeatherForecast weather2 = WeatherForecast.GetInstance();
        //Console.WriteLine(weather2.Date);

        // 多线程去调用
        for (int i = 0; i < 3; i++)
        {
            var th = new Thread(
                new ParameterizedThreadStart((state) =>
                {
                    WeatherForecast.GetInstance();
                })
            );
            th.Start(i);
        }
        Console.ReadKey();
        for (int i = 0; i < 3; i++)
        {
            var th = new Thread(
                new ParameterizedThreadStart((state) =>
                {
                    WeatherForecast.GetInstance();
                })
            );
            th.Start(i);
        }
    }
}