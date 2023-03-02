using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Two : Strategy
    {
        public void Method(string option)
        {
            Console.WriteLine("执行策略2");
        }
    }
}
