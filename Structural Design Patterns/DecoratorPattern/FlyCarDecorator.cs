using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// 飞行装饰类
    /// </summary>
    public class FlyCarDecorator : CarDecorator
    {
        public FlyCarDecorator(Car car) : base(car)
        {
        }
        public override void Run()
        {
            base.Run();
            Fly();
        }

        private void Fly()
        {
            Console.WriteLine("开启飞行模式");
        }
    }
}
