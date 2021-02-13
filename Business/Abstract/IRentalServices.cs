using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalServices
    {
        void Add(Rentals rental);
        List<Rentals> GetAll();
        void Delete(Rentals rental);
        void Update(Rentals rental);
    }
}
