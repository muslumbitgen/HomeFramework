using HomeFramework.Business.Abstract;
using HomeFramework.Business.Constants;
using HomeFramework.Core.Utilities.Results;
using HomeFramework.DataAccess.Abstract;
using HomeFramework.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeFramework.Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        private IArticleDal _articleDal;
        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }
        public IResult Add(Article article)
        {
            _articleDal.Add(article);
            return new SuccessResult(Messages.ArticleAdded);

        }

        public IResult Delete(Article article)
        {
            _articleDal.Delete(article);
            return new SuccessResult(Messages.ArticleDeleted);

        }

        public IDataResult<Article> GetById(int articleId)
        {
            return new SuccessDataResult<Article>(_articleDal.Get(a => a.ArticleId == articleId));
        }

        public IDataResult<List<Article>> GetList()
        {
            return new SuccessDataResult<List<Article>>(_articleDal.GetList().ToList());
        }
      
        public IDataResult<List<Article>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Article>>(_articleDal.GetList(a => a.CategoryId == categoryId).ToList());
        }

        public IResult Update(Article article)
        {
            _articleDal.Update(article);
            return new SuccessResult(Messages.ArticleUpdated);
        }
    }
}
