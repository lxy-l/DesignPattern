using System;

namespace FactoryPattern
{
    /// <summary>
    /// 定义仓储抽象类
    /// </summary>
    public abstract class Repository
    {
        /// <summary>
        /// 抽象方法，获取数据
        /// </summary>
        public abstract void GetData();
    }
}