using Entity.Concreate;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        List<Cars> GetAll();

        List<Cars> GetAllByCategory(int id);
        void Add(Cars car);
        List<CarsDetailDto> carsDetails();




    }
}
