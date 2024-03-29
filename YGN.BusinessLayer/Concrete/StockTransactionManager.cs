﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.BusinessLayer.Abstract;
using YGN.DataAccesLayer.Abstract;
using static Entities.Extensions.Extensions;

namespace YGN.BusinessLayer.Concrete
{
    public class StockTransactionManager : IStockTransactionService
    {
        private readonly IStockTransactionDal _stockTransactionDal;

        public StockTransactionManager(IStockTransactionDal stockTransactionDal)
        {
            _stockTransactionDal = stockTransactionDal;
        }

        public void AddToStockTransaction(StockTransaction stockTransaction)
        {
            _stockTransactionDal.Add(stockTransaction);
        }

        public List<StockTransaction_View> GetStockTransactions()
        {
            return _stockTransactionDal.GetStockTransactions();
        }
    }
}
