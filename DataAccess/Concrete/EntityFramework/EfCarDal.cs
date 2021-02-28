using Core.DataAcces.EntityFramework;
using Core.Entities;
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
    public class EfCarDal : EfEntityRespositoryBase<Car, RentCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarsDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from cars in context.Cars
                             join colors in context.Colors
                             on cars.ColorId equals colors.Id
                             join brands in context.Brands
                             on cars.BrandId equals brands.Id
                             select new CarDetailDto
                             {
                                 Brand = brands.Brand,
                                 Color = colors.Color,
                                 DailyPrice = cars.DailyPrice,
                                 Id = cars.Id
                             };
                return result.ToList();
            }
        }
    }
}
