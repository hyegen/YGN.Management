using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Item : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public double? UnitPrice { get; set; }
        public string Category1 { get; set; }
        public string Category2 { get; set; }
        public string Category3 { get; set; }
        public string Category4 { get; set; }
        public string Brand { get; set; }
       // public bool ItemStatus { get; set; }
    }
}
