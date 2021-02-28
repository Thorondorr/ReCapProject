using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer customer);
        IDataResult<List<Customer>> GetAll();
        IResult Delete(Customer customers);
        IResult Update(Customer customers);

    }
}
