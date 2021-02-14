using Core.Utilities.Results;
using Entity.Concreate;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        IDataResult<List<Cars>> GetAll();
        IDataResult<List<Cars>> GetAllByCategory(int id);
        IResult Add(Cars car);
        IResult Delete(Cars car);
        IResult Update(Cars car);
        IDataResult<List<CarsDetailDto>> carsDetails();




    }
}
