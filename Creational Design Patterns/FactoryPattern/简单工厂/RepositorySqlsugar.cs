using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 定义一个 Sqlsugar 仓储
    /// </summary>
    public class RepositorySqlsugar : Repository
    {
        public override void GetData()
        {
            Console.WriteLine("获取 Sqlsugar 全部数据！");
        }
    }
}
