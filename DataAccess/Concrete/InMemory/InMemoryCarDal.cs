using DataAccess.Abstract;
using Entity.Concreate;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Cars> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Cars>
            {
                new Cars{Id=1,ModelYear=1996 ,BrandId=1,ColorId=1,DailyPrice=25,Description="Araba_1"},
                new Cars{Id=2,ModelYear=1997 ,BrandId=2,ColorId=2,DailyPrice=225,Description="Araba_2"},
                new Cars{Id=3,ModelYear=1998 ,BrandId=3,ColorId=3,DailyPrice=325,Description="Araba_3"},
                new Cars{Id=4,ModelYear=1999 ,BrandId=4,ColorId=4,DailyPrice=425,Description="Araba_4"},
                new Cars{Id=5,ModelYear=2001 ,BrandId=5,ColorId=5,DailyPrice=525,Description="Araba_5"},
            };
        }
        public void Add(Cars car)
        {
            _cars.Add(car);
        }

        public void Delete(Cars car)
        {
            Cars carToDelete = null;

            carToDelete = _cars.SingleOrDefault(p => p.Id == carToDelete.Id);

            _cars.Remove(carToDelete);
        }

        public List<Cars> GetAll()
        {
            return _cars;
        }

        public List<Cars> GetAll(Expression<Func<Cars, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarsDetailDto> GetCarsDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Cars car)
        {
            Cars carToUpdate = null;
            carToUpdate = _cars.SingleOrDefault(predicate => predicate.Id == carToUpdate.Id);

            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
