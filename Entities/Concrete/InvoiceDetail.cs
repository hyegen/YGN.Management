using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class InvoiceDetail
    {
        [Key]
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int OrderDetailId { get; set; }
        public int ItemId { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }
    }
}
