using CoreLayer.DataAccess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.DataAccesLayer.Abstract;
using static Entities.Extensions.Extensions;

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

        public List<OrderLine_View> GetOrderLine()
        {
            using (YGNContext context = new YGNContext())
            {
                var result = context.Database.SqlQuery<OrderLine_View>($"EXEC YGN_GET_ITEM_FOR_FILLING_PURCHASE_ITEMS_GRID").ToList();
                return result;
            }
        }
    }
}
