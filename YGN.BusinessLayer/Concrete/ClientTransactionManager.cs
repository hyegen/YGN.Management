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
    public class ClientTransactionManager : IClientTransactionService
    {
        IClientTransactionDal _clientTransactionDal;
        public ClientTransactionManager(IClientTransactionDal clientTransactionDal)
        {
            _clientTransactionDal = clientTransactionDal;
        }

        public void addToTranaction(ClientTransaction clientTransaction)
        {
     
            _clientTransactionDal.Add(clientTransaction);
        }
    }
}
