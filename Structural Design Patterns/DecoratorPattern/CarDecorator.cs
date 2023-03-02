using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
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
}
