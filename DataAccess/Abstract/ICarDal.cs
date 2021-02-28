using Core.DataAccess;
using Entity.Concreate;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {

        List<CarDetailDto> GetCarsDetails();

    }
}
