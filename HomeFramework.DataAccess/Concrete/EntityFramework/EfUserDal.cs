using HomeFramework.Core.DataAccess.EntityFramework;
using HomeFramework.Core.Entities.Concrete;
using HomeFramework.DataAccess.Abstract;
using HomeFramework.DataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace HomeFramework.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfRepositoryBase<User, BlogContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new BlogContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operationClaim.OperationClaimId equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.UserId
                             select new OperationClaim { OperationClaimId = operationClaim.OperationClaimId, Name = operationClaim.Name };
                return result.ToList();
            }
        }
    }
}
