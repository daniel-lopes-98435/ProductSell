using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsell.domain.Models
{
    public abstract class EntityBase
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}