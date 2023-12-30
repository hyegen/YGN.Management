using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Town
    {
        [Key]
        public int Id { get; set; }
        public int CityId { get; set; }
        public int Description { get; set; }
    }
}
