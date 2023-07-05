using System;

namespace FactoryPattern;

/// <summary>
/// 定义一个 EFCore 仓储
/// 继承仓储父类
/// </summary>
public class RepositoryEFCore : Repository
{
    /// <summary>
    /// 实现父类抽象方法
    /// </summary>
    public override void GetData()
    {
        Console.WriteLine("获取 EFCore 全部数据！");
    }
}