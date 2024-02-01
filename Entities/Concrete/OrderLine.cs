using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class OrderLine
    {
        [Key]
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int Amount { get; set; }
        public int OrderFicheId { get; set; }
        public DateTime ProcessDate { get; set; }
    }
}
