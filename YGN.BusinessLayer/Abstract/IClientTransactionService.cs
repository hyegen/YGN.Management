using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGN.BusinessLayer.Abstract
{
    public interface IClientTransactionService
    {
        void AddToTranaction(ClientTransaction clientTransaction);
    }
}
