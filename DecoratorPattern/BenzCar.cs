using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class BenzCar : Car
    {
        public void Run()
        {
            Console.WriteLine("奔驰开车了");
        }
    }
}
