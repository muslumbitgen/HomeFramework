using HomeFramework.Core.Entities.Concrete;
using HomeFramework.Core.Utilities.Results;
using HomeFramework.Core.Utilities.Security.Jwt;
using HomeFramework.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeFramework.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
