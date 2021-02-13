using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
        public IResult Add(Rentals rental)
        {           
            if(rental.ReturnDate>rental.RentDate && rental.RentDate != null)
            {
               _rentalServices.Add(rental);
                return new Result(true, Messages.RentalAdded);
            }
            return new Result(false, Messages.RentalCanNotAdded);
           
        }

        public IResult Delete(Rentals rental)
        {
            _rentalServices.Delete(rental);

            return new Result(true);
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            return new SuccesDataResult<List<Rentals>>((List<Rentals>)_rentalServices.GetAll(), Messages.RentalsListed); 

        }

        public IResult Update(Rentals rental)
        {
            _rentalServices.Update(rental);
            return new Result(true);
        }
    }
}
