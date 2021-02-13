using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{
    public class Customers:IEntity
    {
        [Key]
        public int UserId { get; set; }
        public string CompanyName { get; set; }

    }
}
