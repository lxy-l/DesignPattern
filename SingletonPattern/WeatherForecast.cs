using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    /**
     *  单例模式：
     
        1、单例类只能有一个实例。

        2、单例类必须自己创建自己的唯一实例。

        3、单例类必须给所有其他对象提供这一实例。
     * 
     * **/
    public class WeatherForecast
    {
        // 定义一个静态变量来保存类的唯一实例
        private static WeatherForecast uniqueInstance;
        // 定义一个锁，防止多线程
        private static readonly object locker = new object();

        // 定义私有构造函数，使外界不能创建该类实例
        private WeatherForecast()
        {
            Date = DateTime.Now;
            var id = System.Threading.Thread.GetCurrentProcessorId();
            Console.WriteLine($"{id}线程：创建了实例：{Date}");
        }
        /// <summary>
        /// 静态方法，来返回唯一实例
        /// 如果存在，则返回
        /// </summary>
        /// <returns></returns>
        public static WeatherForecast GetInstance()
        {
            Console.WriteLine($"{System.Threading.Thread.GetCurrentProcessorId()}线程:实例状态：{uniqueInstance == null}");

            if (uniqueInstance == null)
            {
                lock (locker)
                {
                    Console.WriteLine($"{System.Threading.Thread.GetCurrentProcessorId()}线程:进入lock,实例状态：{uniqueInstance == null}");
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new WeatherForecast();
                    }
                }
            }

            return uniqueInstance;
        }
        public DateTime Date { get; set; }
    }
}
