using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class OrderFiche : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ClientId { get; set; }
        public DateTime ProcessDate { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
