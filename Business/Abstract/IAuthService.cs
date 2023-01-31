using Core.Entities.Concrete;
using Core.Utilities.Result;
using Core.Utilities.Security.JWT;
using Entities.CarDTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<UserCore> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<UserCore> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(UserCore user);
    }
}

