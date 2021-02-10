using Core.DataAcces.EntityFramework;
using DataAccess.Abstract;
using Entity.Concreate;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRespositoryBase<Cars, RentCarContext>, ICarDal
    {
        public List<CarsDetailDto> GetCarsDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from cars in context.Cars
                             join colors in context.Colors
                             on cars.ColorId equals colors.Id
                             join brands in context.Brands
                             on cars.BrandId equals brands.Id
                             select new CarsDetailDto { Brand = brands.Brand,
                                 Color = colors.Color, DailyPrice = cars.DailyPrice, Id = cars.Id };
                return result.ToList();
            }
        }
    }
}
