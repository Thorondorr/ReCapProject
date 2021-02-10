using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Colors:IEntity
    {
        public int Id { get; set; }
        public string Color { get; set; }

    }
}
