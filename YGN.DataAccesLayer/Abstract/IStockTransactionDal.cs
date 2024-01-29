using CoreLayer.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.Extensions.Extensions;

namespace YGN.DataAccesLayer.Abstract
{
    public interface IStockTransactionDal : IEntityRepository<StockTransaction>
    {
        List<StockTransaction_View> GetStockTransactions();
    }
}
