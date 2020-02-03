using HomeFramework.Core.DataAccess;
using HomeFramework.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeFramework.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
