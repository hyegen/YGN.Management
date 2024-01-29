using Commons.Enums;
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
    public class EfStockTransactionDal : EfGenericRepositoryBase<StockTransaction, YGNContext>, IStockTransactionDal
    {
        public List<StockTransaction_View> GetStockTransactions()
        {
            using (YGNContext context = new YGNContext())
            {
                var result = (from st in context.StockTransactions
                              join itm in context.Items on st.ItemId equals itm.Id
                              join us in context.Users on st.UserId equals us.Id
                              select new StockTransaction_View
                              {
                                  Id = st.Id,
                                  ItemName = itm.ItemName,
                                  OrderId = st.OrderId,
                                  ProcessDate = st.ProcessDate,
                                  TrCode = st.TrCode == (int)Trcode.Input ? "Giriş" : "Çıkış",
                                  UserName = us.NameSurname
                              }).ToList();

                return result;
            }
        }
    }
}
