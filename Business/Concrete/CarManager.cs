using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
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

        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("IProductservice.Get")]
        public IResult Add(Car car)
        {


           // ValidationTool.Validate(new CarValidator(), car);
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
        [CacheRemoveAspect("IProductservice.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new Result(true, Messages.Succesful);
        }

        [CacheAspect]
       
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccesDataResult<List<Car>>(_carDal.GetAll());
        }

        [PerformanceAspect(5)]
        [CacheAspect]
        public IDataResult<List<Car>> GetAllByCategory(int id)
        {
            return new SuccesDataResult<List<Car>>(_carDal.GetAll(p => p.Id == id));
        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
