using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsell.domain.Models
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
    }
}