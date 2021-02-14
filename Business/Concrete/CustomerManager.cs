using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerServices
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customersDal)
        {
            this._customerDal = customersDal;
        }

        public IResult Add(Customers customer)
        {
            _customerDal.Add(customer);
            return new Result(true, Messages.Succesful);
        }

        public IResult Delete(Customers customers)
        {
            _customerDal.Delete(customers);
            return new Result(true, Messages.Succesful);
        }

        public IDataResult<List<Customers>> GetAll()
        {
           return new SuccesDataResult<List<Customers>>(_customerDal.GetAll().ToList());
        }

        public IResult Update(Customers customers)
        {
            _customerDal.Update(customers);
            return new Result(true, Messages.Succesful);
        }
    }
}
