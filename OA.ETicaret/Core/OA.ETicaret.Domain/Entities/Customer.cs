using OA.ETicaret.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.ETicaret.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string FullName { get; set; }
        public string Address { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
