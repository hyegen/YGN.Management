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
    public class ClientConfiguration : EntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {
            Property(x => x.ClientName).IsRequired();
            Property(x => x.ClientName).HasMaxLength(50);
            Property(x => x.ClientSurname).HasMaxLength(50);
            Property(x => x.Email).HasMaxLength(30);
            Property(x => x.TelNr1).HasMaxLength(11);
            Property(x => x.TelNr2).HasMaxLength(11);
            Property(x => x.FirmDescription).HasMaxLength(150);
            Property(x => x.TaxIdentificationNumber).HasMaxLength(10);
            Property(x=>x.ClientCode).HasMaxLength(40);
        }
    }
    public class Client : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string ClientCode { get; set; }
        [Required]
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public string Email { get; set; }
        public string TelNr1 { get; set; }
        public string TelNr2 { get; set; }
        public string FirmDescription { get; set; }
        public string TaxIdentificationNumber { get; set; }
    }
}
