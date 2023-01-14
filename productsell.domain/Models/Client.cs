using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsell.domain.Models
{
    public class Client : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

    }
}