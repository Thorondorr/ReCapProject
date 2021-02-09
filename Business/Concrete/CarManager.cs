using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concreate;
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

        public void Add(Car car)
        {    if(car.Id!=null && car.ModelYear!=null && car.BrandId!=null &&
                car.ColorId != null && car.Description!=null && car.DailyPrice>0)
            {
                _carDal.Add(car);
            }
            else { Console.WriteLine("Boş alanları doldurun!"); }
            
        }

        public List<Car> GetAll()
        {
           return _carDal.GetAll();
        }

        public List<Car> GetAllByCategory(int id)
        {
            return _carDal.GetAll(p => p.Id == id);
        }
    }
}
