using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
          return  new Result(true,Messages.Succesful);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new Result(true);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccesDataResult<List<Brand>>(_brandDal.GetAll(),Messages.RentalAdded);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new Result(true, Messages.Succesful);
        }

        
    }
}
