using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class CarImage:IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string ImagesPath { get; set; }
        public DateTime Date { get; set; }
    }
}
