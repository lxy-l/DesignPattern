using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 1、抽象工厂类
    /// </summary>
    public abstract class RepositoryFactory
    {
        /// <summary>
        /// 抽象方法，用来返回仓储对象
        /// </summary>
        /// <returns></returns>
        public abstract Repository CreateRepository();
    }
}
