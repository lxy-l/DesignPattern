namespace FactoryPattern;

/// <summary>
/// 定义简单仓储工厂
/// </summary>
public class RepositorySimpleFactory
{
    /// <summary>
    /// 定义静态方法，控制实例对象输出
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public static Repository GetRepository(string type)
    {
        Repository repository = null;
        if (type.Equals("sugar"))
        {
            repository = new RepositorySqlsugar();
        }
        else if (type.Equals("efcore"))
        {
            repository = new RepositoryEFCore();
        }
        return repository;
    }
}