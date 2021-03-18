using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    /**
     * 
     * 策略模式：
     *      1.定义一系列的算法,把它们一个个封装起来, 并且使它们可相互替换。
     *      2.在有多种算法相似的情况下，使用 if...else 所带来的复杂和难以维护。
     *      3.算法可以自由切换。 2、避免使用多重条件判断。 3、扩展性良好。
     *      4.如果在一个系统里面有许多类，它们之间的区别仅在于它们的行为，那么使用策略模式可以动态地让一个对象在许多行为中选择一种行为。 2、一个系统需要动态地在几种算法中选择一种。 3、如果一个对象有很多的行为，如果不用恰当的模式，这些行为就只好使用多重的条件选择语句来实现。
     * 
     * **/

    public class Program
    {
        private static List<Context> algs = new List<Context>();

        static Program()
        {
            algs.Add(new Context("1", new One()));
            algs.Add(new Context("2", new Two()));
        }
        static void Main(string[] args)
        {
            ShareOptions("1");
        }

        public static void ShareOptions(string type)
        {
            
            Strategy dealStrategy = null;
            foreach (Context deal in algs)
            {
                if (deal.Options(type))
                {
                    dealStrategy = deal.GetStrategy();
                    break;
                }
            }
            dealStrategy.Method(type);
        }
    }
}
