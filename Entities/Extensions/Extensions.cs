using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Extensions
{
    public class Extensions
    {
  
        public class Client_View
        {
            public int Id { get; set; }
            public string ClientCode { get; set; }
            public string ClientName { get; set; }
            public string ClientSurname { get; set; }
            public string Address { get; set; }
            public string TelNr1 { get; set; }
            public string TelNr2 { get; set; }
            public string FirmDescription { get; set; }
            public string TaxIdentificationNumber { get; set; }
        }

        public class StockTransaction_View
        {
            public int Id { get; set; }
            public string ItemName { get; set; }
            public int? OrderId { get; set; }
            public string UserName { get; set; }
            public DateTime ProcessDate { get; set; }
            public string TrCode { get; set; }
        }

        public class OrderLine_View
        {
            public int Id { get; set; }
            public int ItemId { get; set; }
            public int Amount { get; set; }
            public int OrderFicheId { get; set; }
            public DateTime ProcessDate { get; set; }
        }
    }
}
