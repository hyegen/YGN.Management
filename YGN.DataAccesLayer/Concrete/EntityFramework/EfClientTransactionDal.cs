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
    public class EfClientTransactionDal : EfGenericRepositoryBase<ClientTransaction, YGNContext>, IClientTransactionDal
    {
        public void addToTranaction(ClientTransaction clientTransaction)
        {
            using (YGNContext context= new YGNContext())
            {
                context.ClientTransactions.Add(clientTransaction);
            }
        }
    }
}
