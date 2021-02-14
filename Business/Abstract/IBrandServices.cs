using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandServices
    {
        IDataResult<List<Brands>> GetAll();
        IResult Add(Brands brand);
        IResult Delete(Brands brand);
        IResult Update(Brands brand);
       

    }
}
