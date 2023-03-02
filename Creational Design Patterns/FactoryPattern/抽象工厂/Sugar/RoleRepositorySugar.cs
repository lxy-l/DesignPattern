using FactoryPattern.抽象工厂.Core;

namespace FactoryPattern.抽象工厂.Sugar
{
    internal class RoleRepositorySugar : RoleRepository
    {
        public override void Add()
        {
            throw new System.NotImplementedException();
        }

        public override void Delete()
        {
            throw new System.NotImplementedException();
        }

        public override void Query()
        {
            throw new System.NotImplementedException();
        }

        public override void Update()
        {
            throw new System.NotImplementedException();
        }
    }
}