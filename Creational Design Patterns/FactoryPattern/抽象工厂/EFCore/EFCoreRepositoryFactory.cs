using FactoryPattern.抽象工厂.Core;

namespace FactoryPattern.抽象工厂.EFCore;

/// <summary>
/// EFCore 仓储子工厂
/// 用来生产各个实体仓储
/// </summary>
public class EFCoreRepositoryFactory : AbstractFactory
{
    public override PermissionRepository PermissionRepository()
    {
        return new PermissionRepositoryEFCore();
    }

    public override RoleRepository RoleRepository()
    {
        return new RoleRepositoryEFCore();
    }

    public override UserRepository UserRepository()
    {
        return new UserRepositoryEFCore();
    }
}