using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Context
    {
        private string Type;
        private Strategy Strategy;

        public Context(string type,Strategy strategy)
        {
            Type = type;
            Strategy = strategy;
        }

        public Strategy GetStrategy()
        {
            return Strategy;
        }

        public bool Options(string type)
        {
            return Type == type;
        }

    }
}
