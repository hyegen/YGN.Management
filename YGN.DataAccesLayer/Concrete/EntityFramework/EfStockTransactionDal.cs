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
    public class EfStockTransactionDal : EfGenericRepositoryBase<StockTransaction, YGNContext>, IStockTransactionDal
    {
        public void AddToStockTranaction(StockTransaction stockTransaction)
        {
            throw new NotImplementedException();
        }
    }
}
