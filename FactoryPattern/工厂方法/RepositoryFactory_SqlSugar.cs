using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 2.1、EFCore 的仓储工厂
    /// 继承抽象仓储工厂
    /// </summary>
    public class RepositoryFactory_SqlSugar : RepositoryFactory
    {
        /// <summary>
        /// 重写，生成 SqlSugar 仓储的实例
        /// </summary>
        /// <returns></returns>
        public override Repository CreateRepository()
        {
            return new RepositorySqlsugar();
        }
    }
}
