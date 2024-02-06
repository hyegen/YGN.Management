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
        public List<Client> GetAllClients()
        {
            return _clientDal.GetAllClient();
        }
        public void AddClient(Client client)
        {
            if (!IsSimilarClientExists(client))
            {
                _clientDal.Add(client);
            }
        }
        public bool IsSimilarClientExists(Client newClient)
        {
            foreach (var existingClient in _clientDal.GetAllClient())
            {
                if (existingClient != null && existingClient.ClientCode != null && IsSimilarCode(existingClient.ClientCode, newClient.ClientCode))
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsSimilarCode(string existClientCode, string newClientCode)
        {
            if (existClientCode == null || newClientCode == null)
            {
                return false;
            }
            return existClientCode.Equals(newClientCode, StringComparison.OrdinalIgnoreCase);
        }
        public string GetClientCode()
        {
            return _clientDal.GetClientCode();
        }
        public Client GetClientById(int id)
        {
            return _clientDal.GetClientById(id);
        }
        public bool DeleteClientById(int id)
        {
            return _clientDal.DeleteClientById(id);
        }
    }
}
