using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concreate;
using Entity.Concrete;
using System;
using System.Linq;

namespace ConsoleUI
{
    public class Program
    {
        
        
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = carManager.GetAll();
            foreach(var sa in result.Data)
            {
                Console.WriteLine(sa.BrandId);
            }
        }

       

        
    }
}
