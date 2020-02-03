using HomeFramework.Core.DataAccess;
using HomeFramework.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeFramework.DataAccess.Abstract
{
    public interface IArticleDal : IEntityRepository<Article>
    {
    }
}
