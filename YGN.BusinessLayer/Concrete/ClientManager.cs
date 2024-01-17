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
    public class ClientManager : IClientService
    {
        private readonly IClientDal _clientDal;
        public ClientManager(IClientDal clientDal)
        {
            _clientDal = clientDal;
        }
        public List<Client> getAllClients()
        {
            return _clientDal.getAllItems();
        }
        public void addClient(Client client)
        {
            _clientDal.Add(client);
        }
    }
}
