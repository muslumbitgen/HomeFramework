﻿using HomeFramework.Business.Abstract;
using HomeFramework.Core.Entities.Concrete;
using HomeFramework.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeFramework.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string mail)
        {
            return _userDal.Get(u => u.Email == mail);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }
    }
}
