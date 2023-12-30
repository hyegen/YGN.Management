using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CityConfiguration : EntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {
            Property(e => e.Description)
                .IsRequired();
        }
    }
    public class City
    {
        [Key]
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Description { get; set; } ///Nullable Yapılacak
        public int? District { get; set; }
    }
}
