using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concreate;
using Entity.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Cars car)
        {
            var context = new ValidationContext<Cars>(car);
            

            _carDal.Add(car);
            return new Result(true, Messages.RentalAdded);



        }

        public IDataResult<List<CarsDetailDto>> carsDetails()
        {
            return new SuccesDataResult<List<CarsDetailDto>>(_carDal.GetCarsDetails());
        }

        public IResult Delete(Cars car)
        {
            _carDal.Delete(car);
            return new Result(true, Messages.Succesful);
        }
        public IResult Update(Cars car)
        {
            _carDal.Update(car);
            return new Result(true, Messages.Succesful);
        }

        public IDataResult<List<Cars>> GetAll()
        {
            return new SuccesDataResult<List<Cars>>(_carDal.GetAll());
        }

        public IDataResult<List<Cars>> GetAllByCategory(int id)
        {
            return new SuccesDataResult<List<Cars>>(_carDal.GetAll(p => p.Id == id));
        }
    }
}
