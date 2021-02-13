using Business.Abstract;
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
        public void Add(Users user)
        {
            _userDal.Add(user);
        }

        public void Delete(Users user)
        {
            _userDal.Delete(user);
        }

        public List<Users> GetAll()
        {
            return _userDal.GetAll().ToList();
        }

        public void Update(Users user)
        {
            _userDal.Update(user);
        }
    }
}
