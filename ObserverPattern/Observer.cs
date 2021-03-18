using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 观察者
    /// 接口或抽象类按情况选择使用
    /// </summary>
    public abstract class Observer
    {

        protected Subject Subject;
        /// <summary>
        /// 观察者做出反应
        /// </summary>
        public abstract void Update();
    }
}
