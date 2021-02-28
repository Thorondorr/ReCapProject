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

        public IResult Add(Car car)
        {
            var context = new ValidationContext<Car>(car);
            

            _carDal.Add(car);
            return new Result(true, Messages.RentalAdded);



        }

        public IDataResult<List<CarDetailDto>> carsDetails()
        {
            return new SuccesDataResult<List<CarDetailDto>>(_carDal.GetCarsDetails());
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new Result(true, Messages.Succesful);
        }
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new Result(true, Messages.Succesful);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccesDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<Car>> GetAllByCategory(int id)
        {
            return new SuccesDataResult<List<Car>>(_carDal.GetAll(p => p.Id == id));
        }
    }
}
