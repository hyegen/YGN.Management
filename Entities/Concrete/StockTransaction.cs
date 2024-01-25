using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class StockTransactionConfiguration : EntityTypeConfiguration<StockTransaction>
    {
        public StockTransactionConfiguration()
        {
            Property(u => u.ProcessDate)
                .HasColumnType("date");
        }
    }
    public class StockTransaction : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int? OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime ProcessDate { get; set; }
        public int TrCode { get; set; }
    }
}
