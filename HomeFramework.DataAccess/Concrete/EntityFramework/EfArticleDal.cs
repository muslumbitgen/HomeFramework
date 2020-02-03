using HomeFramework.Core.DataAccess.EntityFramework;
using HomeFramework.DataAccess.Abstract;
using HomeFramework.DataAccess.Concrete.EntityFramework.Contexts;
using HomeFramework.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeFramework.DataAccess.Concrete.EntityFramework
{
    public class EfArticleDal : EfRepositoryBase<Article, BlogContext>, IArticleDal
    {
    }
}
