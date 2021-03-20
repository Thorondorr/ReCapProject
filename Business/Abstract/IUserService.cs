using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        
        IDataResult<List<User>> GetAll();
        IResult Delete(User user);
        IResult Update(User user);
        List<OperationClaim> GetClaims(User user);
        IResult Add(User user);
        User GetByMail(string email);
    }
}
