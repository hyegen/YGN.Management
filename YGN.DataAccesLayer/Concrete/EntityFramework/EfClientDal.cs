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
    public class EfClientDal : EfGenericRepositoryBase<Client, YGNContext>, IClientDal
    {
        public List<Client> getAllClient()
        {
            List<Client> clients = new List<Client>();

            using (YGNContext context = new YGNContext())
            {
                var allClients = context.Database.SqlQuery<Client>("EXEC YGN_GET_ALL_CLIENT").ToList();
                clients.AddRange(allClients);
            }
            return clients;
        }
        public string getClientCode()
        {
            string str;
            using (YGNContext context= new YGNContext())
            {
                var result = context.Database.SqlQuery<string>("EXEC YGN_CLIENTCODECREATOR").FirstOrDefault();
                str = result;
            }
            return str;
        }
    }
}
