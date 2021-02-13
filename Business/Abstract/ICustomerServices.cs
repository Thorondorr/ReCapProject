using System;
using System.Collections.Generic;
using System.Text;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface ICustomerServices
    {
        void Add(Customers customer);
        List<Customers> GetAll();
        void Delete(Customers customers);
        void Update(Customers customers);

    }
}
