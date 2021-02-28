using Core.DataAcces.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUsersDal : EfEntityRespositoryBase<User, RentCarContext>, IUserDal
    {
      
    }
}
