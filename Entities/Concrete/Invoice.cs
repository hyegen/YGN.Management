using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class InvoiceConfiguration : EntityTypeConfiguration<Invoice>
    {
        public InvoiceConfiguration()
        {
            Property(e => e.CargoFicheNo)
                .HasMaxLength(50);
        }
    }
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public DateTime ProcessDate { get; set; }
        public int AddressId { get; set; }
        public string CargoFicheNo { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
