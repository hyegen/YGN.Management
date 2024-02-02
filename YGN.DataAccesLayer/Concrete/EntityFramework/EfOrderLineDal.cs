using CoreLayer.DataAccess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.DataAccesLayer.Abstract;

namespace YGN.DataAccesLayer.Concrete.EntityFramework
{
    public class EfOrderLineDal : EfGenericRepositoryBase<OrderLine, YGNContext>, IOrderLineDal
    {
        public void AddToOrderLine(OrderLine orderLine)
        {
            using (YGNContext context = new YGNContext())
            {
                context.OrderLines.Add(orderLine);
                context.SaveChanges();
            }
        }
    }
}
