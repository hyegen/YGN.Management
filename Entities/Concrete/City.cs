using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class City
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int Description { get; set; }
        public int District { get; set; }
    }
}
