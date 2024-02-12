using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.Extensions.Extensions;

namespace YGN.BusinessLayer.Abstract
{
    public interface IOrderLineService
    {
        void AddToOrderLine(OrderLine orderLine);

        List<OrderLine_View> GetOrderLine();
    }
}
