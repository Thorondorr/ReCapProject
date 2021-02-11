using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity.DTOs
{
    public class CarsDetailDto : IDto
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }

        [Column(TypeName="money")]
        public decimal DailyPrice { get; set; }
    }
}
