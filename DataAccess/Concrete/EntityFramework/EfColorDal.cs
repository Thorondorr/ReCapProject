using Core.DataAcces.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRespositoryBase<Colors, RentCarContext>, IColorDal
    {
       
    }
}
