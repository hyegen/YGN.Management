using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Payment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int PaymentType { get; set; }
        public DateTime ProcessDate { get; set; }
        public bool IsOk { get; set; }
        public string ApproveCode { get; set; }
        public string PaymentTotal { get; set; }
    }
}
