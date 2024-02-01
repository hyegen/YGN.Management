using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class OrderFiche
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public int ClientId { get; set; }
        public double Amount { get; set; }
        public DateTime ProcessDate { get; set; }
        public decimal TotalPrice { get; set; }
        public List<OrderLine> OrderLines { get; set; }
    }
}
