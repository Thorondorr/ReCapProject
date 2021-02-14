using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserServices
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add(Users user)
        {
            _userDal.Add(user);
            return new Result(true, Messages.Succesful);
        }

        public IResult Delete(Users user)
        {
            _userDal.Delete(user);
            return new Result(true, Messages.Succesful);
        }

        public IDataResult<List<Users>> GetAll()
        {
            return new SuccesDataResult<List<Users>>(_userDal.GetAll().ToList());
        }

        public IResult Update(Users user)
        {
            _userDal.Update(user);
            return new Result(true, Messages.Succesful);
        }
    }
}
