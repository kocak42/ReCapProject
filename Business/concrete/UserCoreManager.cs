﻿using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.concrete
{
    public class UserCoreManager : IUserCoreService
    {
        IUserCoreDal _userCoreDal;

        public UserCoreManager(IUserCoreDal userCoreDal)
        {
            _userCoreDal = userCoreDal;
        }

        public List<OperationClaim> GetClaims(UserCore user)
        {
            return _userCoreDal.GetClaims(user);
        }

        public void Add(UserCore user)
        {
            _userCoreDal.Add(user);
        }

        public UserCore GetByMail(string email)
        {
            return _userCoreDal.Get(u => u.Email == email);
        }
    }
}
