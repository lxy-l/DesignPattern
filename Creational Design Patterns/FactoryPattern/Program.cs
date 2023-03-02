using FactoryPattern.抽象工厂;
using FactoryPattern.抽象工厂.Core;
using FactoryPattern.抽象工厂.EFCore;
using FactoryPattern.抽象工厂.Sugar;

namespace FactoryPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region 简单工厂
            Repository sugar = RepositorySimpleFactory.GetRepository("sugar");
            sugar.GetData();

            Repository efcore = RepositorySimpleFactory.GetRepository("efcore");
            efcore.GetData();
            #endregion

            #region 工厂方法
            // 初始化创建Repository的两个仓储工厂
            RepositoryFactory efcoreRepositoryFactory = new RepositoryFactory_EFCore();
            RepositoryFactory sugarRepositoryFactory = new RepositoryFactory_SqlSugar();

            // 生产efcore仓储的实例
            var efcoreRepository = efcoreRepositoryFactory.CreateRepository();
            efcoreRepository.GetData();

            //生产sugar仓储的实体
            var sugarRepository = sugarRepositoryFactory.CreateRepository();
            sugarRepository.GetData();
            #endregion

            #region 抽象工厂
            // 实例化工厂，这里用来生产 efcore 这一系列的 产品
            AbstractFactory efcoreFactory = new EFCoreRepositoryFactory();
            efcoreFactory.UserRepository().Add();
            efcoreFactory.RoleRepository().Delete();
            efcoreFactory.PermissionRepository().Query();


            // 实例化工厂，这里用来生产 sugar 这一系列的 产品
            AbstractFactory sugarFactory = new SugarRepositoryFactory();
            sugarFactory.UserRepository().Add();
            sugarFactory.RoleRepository().Delete();
            sugarFactory.PermissionRepository().Query();
            #endregion
        }
    }
}