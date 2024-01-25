using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.Extensions.Extensions;

namespace YGN.DataAccesLayer.Concrete
{
    public partial class YGNContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Fluent API

            #region StockTransaction
            modelBuilder.Configurations.Add(new StockTransactionConfiguration());
            #endregion

            #region User
            modelBuilder.Configurations.Add(new UserConfiguration());

            #endregion

            #region City
            modelBuilder.Entity<City>().Property(e => e.Description).HasMaxLength(50);
            #endregion

            #region Invoice
            modelBuilder.Configurations.Add(new InvoiceConfiguration());
            #endregion

            #region Client

            modelBuilder.Configurations.Add(new ClientConfiguration());
            //modelBuilder.Entity<YGN_CLIENTCODECREATOR>().MapToStoredProcedures();

            #endregion

            #endregion
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<StockTransaction> StockTransactions { get; set; }
        public DbSet<ClientTransaction> ClientTransactions { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }


        //PROCEDURES

        #region PROCEDURES

        #region CLIENT PROCEDURES
       // public DbSet<YGN_CLIENTCODECREATOR> YGN_CLIENTCODECREATOR { get; set; }

        #endregion

        #endregion

    }
}
