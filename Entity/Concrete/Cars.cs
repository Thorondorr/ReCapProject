using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Entity.Concreate
{
    public class Cars:IEntity
    {
       // private DateTime year;
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get ; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }

    }
}
