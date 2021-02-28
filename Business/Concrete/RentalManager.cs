using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
       
        public RentalManager(IRentalDal rentalDal)
        {
             _rentalDal= rentalDal;
        }

        public IResult Add(Rental rental)
        {           
            if(rental.ReturnDate>rental.RentDate && rental.RentDate != null)
            {
                _rentalDal.Add(rental);
                return new Result(true, Messages.RentalAdded);
            }
            return new Result(false, Messages.RentalCanNotAdded);
           
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);

            return new Result(true, Messages.Succesful);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccesDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalsListed); 

        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new Result(true, Messages.Succesful);
        }
    }
}
