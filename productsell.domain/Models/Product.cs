using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsell.domain.Models
{
    public class Product : EntityBase
    {
        public string Description { get; set; }
        public double SellValue { get; set; }
        public int Stock { get; set; }
    }
}