using CoreLayer.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGN.DataAccesLayer.Abstract
{
    public interface IOrderFicheDal : IEntityRepository<OrderFiche>
    {
        void AddToOrderFiche(OrderFiche orderFiche);
    }
}
