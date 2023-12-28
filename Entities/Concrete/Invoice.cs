using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Invoice
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public DateTime ProcessDate { get; set; }
        public int AddressId { get; set; }
        public string CargoFicheNo { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
