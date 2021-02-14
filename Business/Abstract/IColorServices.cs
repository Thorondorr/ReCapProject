using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorServices
    {
        IDataResult<List<Colors>> GetAll();
        IResult Add(Colors color);
        IResult Delete(Colors color);
        IResult Update(Colors color);

    }
}
