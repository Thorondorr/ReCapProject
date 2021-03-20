using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new Result(true, Messages.Succesful);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccesDataResult<List<User>>(_userDal.GetAll().ToList());
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new Result(true, Messages.Succesful);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);

            return new SuccesResutl();
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
    }
}
