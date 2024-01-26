using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGN.BusinessLayer.Abstract
{
    public interface IClientService
    {
        List<Client> GetAllClients();
        void AddClient(Client client);
        bool IsSimilarClientExists(Client newClient);
        bool IsSimilarCode(string existClientCode, string newClientCode);
        string GetClientCode();
    }
}
