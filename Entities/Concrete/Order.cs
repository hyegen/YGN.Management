using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Order
    {
        public int Id{ get; set; }
        public int UserId { get; set; }
        public DateTime ProcessDate { get; set; }
        public decimal TotalPrice { get; set; }
        public bool OrderStatus { get; set; }
        public int AddressId { get; set; }
    }
}
