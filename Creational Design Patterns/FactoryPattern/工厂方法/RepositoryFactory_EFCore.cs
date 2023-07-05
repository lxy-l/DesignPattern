namespace FactoryPattern;

/// <summary>
/// 2.1、EFCore 的仓储工厂
/// 继承抽象仓储工厂
/// </summary>
public class RepositoryFactory_EFCore : RepositoryFactory
{
    /// <summary>
    /// 重写，生成EFCore 仓储的实例
    /// </summary>
    /// <returns></returns>
    public override Repository CreateRepository()
    {
        return new RepositoryEFCore();
    }
}