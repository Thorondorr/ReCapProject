using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalServices
    {
        IResult Add(Rentals rental);
        IDataResult<List<Rentals>> GetAll();
        IResult Delete(Rentals rental);
        IResult Update(Rentals rental);
    }
}
