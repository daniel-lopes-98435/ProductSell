using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsell.domain.Models
{
    public class Order
    {
        public Client Client { get; set; }
        public User User { get; set; }
    }
}