using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.抽象工厂.Core
{
    /// <summary>
    /// 定义抽象的基类仓储
    /// </summary>
    public abstract class BaseRepository
    {
        /// <summary>
        /// 创建
        /// </summary>
        public abstract void Add();
        /// <summary>
        /// 删除
        /// </summary>
        public abstract void Delete();
        /// <summary>
        /// 修改
        /// </summary>
        public abstract void Update();
        /// <summary>
        /// 查询
        /// </summary>/ 
        public abstract void Query();
    }
}
