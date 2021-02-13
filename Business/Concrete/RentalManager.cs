using Business.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalServices
    {
        IRentalServices _rentalServices;
        public void Add(Rentals rental)
        {
            _rentalServices.Add(rental);
        }

        public void Delete(Rentals rental)
        {
            _rentalServices.Delete(rental);
        }

        public List<Rentals> GetAll()
        {
          return  _rentalServices.GetAll().ToList();
        }

        public void Update(Rentals rental)
        {
            _rentalServices.Update(rental);
        }
    }
}
