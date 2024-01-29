using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGN.BusinessLayer.Abstract
{
    public interface IStockTransactionService
    {
        //List<StockTransaction> GetStockTransactions();
        void AddToStockTransaction(StockTransaction stockTransaction);
    }
}
