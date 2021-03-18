using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class BMWCar : Car
    {
        public void Run()
        {
            Console.WriteLine("宝马开车了");
        }
    }
}
