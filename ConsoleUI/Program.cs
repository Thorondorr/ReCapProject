using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concreate;
using System;

namespace ConsoleUI
{
    public class Program
    {
        
        
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //ColorManager colorManager = new ColorManager(new EfColorDal());

            Cars car;


            foreach (var a in carManager.GetAll())
            {
                Console.WriteLine(a.BrandId);
            }

                     
        }
    }
}
