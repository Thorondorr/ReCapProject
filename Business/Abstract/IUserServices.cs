using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserServices
    {
        IResult Add(Users user);
        IDataResult<List<Users>> GetAll();
        IResult Delete(Users user);
        IResult Update(Users user);
    }
}
