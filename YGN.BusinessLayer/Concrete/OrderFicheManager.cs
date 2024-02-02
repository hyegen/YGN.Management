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
    public class OrderFicheManager : IOrderFicheService
    {
        private readonly IOrderFicheDal _orderFicheDal;
        public OrderFicheManager(IOrderFicheDal orderFicheDal)
        {
            _orderFicheDal = orderFicheDal;
        }
        public void AddToOrderfiche(OrderFiche orderFiche)
        {
            _orderFicheDal.AddToOrderFiche(orderFiche);
        }
    }
}
