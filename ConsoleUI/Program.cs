using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concreate;
using Entity.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        
        
        static void Main(string[] args)
        {
            //UsersTest();
            //CarManager();

        }

        private static void UsersTest()
        {
            //CarManager();
            UserManager user = new UserManager(new EfUsersDal());

            Users users;

            user.Add(new Users()
            {
                Email = "feyza.kcn@gmail.com",
                FirstName = "Feyza",
                LastName = "Kaçan",
                Password = "123"
            });

            foreach (var usr in user.GetAll())
            {
                Console.WriteLine(usr.Id + "/" + usr.FirstName + " " + usr.LastName);
            }
        }

        private static void CarManager()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //ColorManager colorManager = new ColorManager(new EfColorDal());

            Cars car;


            foreach (var a in carManager.carsDetails())
            {
                Console.WriteLine(a.Id + "/" + a.DailyPrice + "/" + a.Brand + "/" + a.Color);
            }
        }
    }
}
