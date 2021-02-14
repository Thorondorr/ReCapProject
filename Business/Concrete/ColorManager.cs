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
    public class ColorManager : IColorServices
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Colors color)
        {
            _colorDal.Add(color);
            return new Result(true, Messages.Succesful);
        }

        public IResult Delete(Colors color)
        {
            _colorDal.Delete(color);
            return new Result(true, Messages.Succesful); ;
        }

        public IDataResult<List<Colors>> GetAll()
        {
            return new SuccesDataResult<List<Colors>>(_colorDal.GetAll(),Messages.RentalAdded);
        }

        public IResult Update(Colors color)
        {
            _colorDal.Update(color);
            return new Result(true, Messages.Succesful);
        }

        IDataResult<List<Colors>> IColorServices.GetAll()
        {
           return new SuccesDataResult<List<Colors>>(_colorDal.GetAll());
        }
    }
}
