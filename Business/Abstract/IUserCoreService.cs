using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserCoreService
    {
        List<OperationClaim> GetClaims(UserCore user);
        void Add(UserCore user);
        UserCore GetByMail(string email);
    }
}
