using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public float UnitPrice { get; set; }
        public string Categorty1 { get; set; }
        public string Categorty2 { get; set; }
        public string Categorty3 { get; set; }
        public string Categorty4 { get; set; }
        public string Brand { get; set; }
        public bool ItemStatus { get; set; }
    }
}
