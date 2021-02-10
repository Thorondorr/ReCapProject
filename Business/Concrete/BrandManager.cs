using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class BrandManager : IBrandServices
    {
        IBrandDal brandDal;
        public List<Brands> GetAll()
        {
            return brandDal.GetAll();
        }
    }
}
