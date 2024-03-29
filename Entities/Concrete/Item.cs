﻿using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ItemConfiguration : EntityTypeConfiguration<Item>
    {
        public ItemConfiguration()
        {
            Property(x => x.ItemCode).HasMaxLength(40);
            Property(x => x.ItemName).HasMaxLength(50);
            Property(x => x.Brand).HasMaxLength(30);
        }
    }
    public class Item : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public double? UnitPrice { get; set; }
        public string Brand { get; set; }
        public int? Amount { get; set; }
    }
}
