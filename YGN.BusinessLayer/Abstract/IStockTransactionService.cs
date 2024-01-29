using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.Extensions.Extensions;

namespace YGN.BusinessLayer.Abstract
{
    public interface IStockTransactionService
    {
        List<StockTransaction_View> GetStockTransactions();
        void AddToStockTransaction(StockTransaction stockTransaction);
    }
}
