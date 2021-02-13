using Business.Abstract;
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

        public void Add(Customers customer)
        {
            _customerDal.Add(customer);
        }

        public void Delete(Customers customers)
        {
            _customerDal.Delete(customers);
        }

        public List<Customers> GetAll()
        {
           return _customerDal.GetAll().ToList();
        }

        public void Update(Customers customers)
        {
            _customerDal.Update(customers);
        }
    }
}
