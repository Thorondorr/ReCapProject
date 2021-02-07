using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        
        
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            
            foreach(var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
            }

            Console.WriteLine("Ekeleme yapmak için 'a' i tuşlayın");
            string _key=Console.ReadKey().ToString();

            if (_key == "a")
            {

            }
            
        }
    }
}
