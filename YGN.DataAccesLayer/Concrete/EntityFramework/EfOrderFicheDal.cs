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
    public class EfOrderFicheDal : EfGenericRepositoryBase<OrderFiche, YGNContext>, IOrderFicheDal
    {
        public void AddToOrderFiche(OrderFiche orderFiche)
        {
            using (YGNContext context= new YGNContext())
            {
                context.OrderFiches.Add(orderFiche);
                context.SaveChanges();
            }
        }
    }
}
