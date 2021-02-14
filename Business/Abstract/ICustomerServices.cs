using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface ICustomerServices
    {
        IResult Add(Customers customer);
        IDataResult<List<Customers>> GetAll();
        IResult Delete(Customers customers);
        IResult Update(Customers customers);

    }
}
