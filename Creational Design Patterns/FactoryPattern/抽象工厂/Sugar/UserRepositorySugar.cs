using FactoryPattern.抽象工厂.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.抽象工厂.Sugar
{
    /// <summary>
    /// EFCore User 仓储，继承User仓储
    /// </summary>
    public class UserRepositorySugar : UserRepository
    {
        public override void Add()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Query()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
