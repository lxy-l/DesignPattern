using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// 策略接口
    /// </summary>
    public interface Strategy
    {
        public void Method(string option);
    }
}
