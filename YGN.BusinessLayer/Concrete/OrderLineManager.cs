using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.BusinessLayer.Abstract;
using YGN.DataAccesLayer.Abstract;

namespace YGN.BusinessLayer.Concrete
{
    public class OrderLineManager : IOrderLineService
    {
        private readonly IOrderLineDal _orderLineDal;
        public OrderLineManager(IOrderLineDal orderLineDal)
        {
            _orderLineDal = orderLineDal;
        }
        public void AddToOrderLine(OrderLine orderLine)
        {
            _orderLineDal.AddToOrderLine(orderLine);
        }
    }
}
