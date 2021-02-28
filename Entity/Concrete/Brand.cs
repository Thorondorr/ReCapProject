using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
   public class Brand:IEntity
    {
        public int Id { get; set; }
        public string Brand { get; set; }

     //   public int MyProperty { get; set; }
    }
}
