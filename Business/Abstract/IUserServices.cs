using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserServices
    {
        void Add(Users user);
        List<Users> GetAll();
        void Delete(Users user);
        void Update(Users user);
    }
}
