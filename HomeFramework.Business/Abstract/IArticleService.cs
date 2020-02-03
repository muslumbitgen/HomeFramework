using HomeFramework.Core.Utilities.Results;
using HomeFramework.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeFramework.Business.Abstract
{
    public interface IArticleService
    {
        IDataResult<Article> GetById(int articleId);
        IDataResult<List<Article>> GetList();
        IDataResult<List<Article>> GetListByCategory(int categoryId);
        IResult Add(Article article);
        IResult Update(Article article);
        IResult Delete(Article article);

    }
}
