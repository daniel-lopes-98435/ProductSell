using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsell.domain.Models
{
    public class OrderItem : EntityBase
    {
        public Order Order { get; set; }
        public Product Product { get; set; }
        public double SellValue { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; }

    }
}