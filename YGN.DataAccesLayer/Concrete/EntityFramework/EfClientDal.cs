﻿using CoreLayer.DataAccess.EntityFramework;
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
        public List<Client> GetAllClient()
        {
            List<Client> clients = new List<Client>();

            using (YGNContext context = new YGNContext())
            {
                var allClients = context.Database.SqlQuery<Client>("EXEC YGN_GET_ALL_CLIENT").ToList();
                clients.AddRange(allClients);
            }
            return clients;
        }

        public Client GetClientById(int id)
        {
            using (YGNContext context= new YGNContext())
            {
                var result = context.Database.SqlQuery<Client>($"EXEC YGN_GET_CLIENT_BY_ID {id}").FirstOrDefault();
                return result;
            }
        }

        public string GetClientCode()
        {
            string str;
            using (YGNContext context = new YGNContext())
            {
                var result = context.Database.SqlQuery<string>("EXEC YGN_CLIENTCODECREATOR").FirstOrDefault();
                str = result;
            }
            return str;
        }
        public bool DeleteClientById(int id)
        {
            using (YGNContext context= new YGNContext())
            {
                var result =Convert.ToBoolean(context.Database.ExecuteSqlCommand("EXEC YGN_DELETE_CLIENT_BY_ID {0}", id));
                return result;
            }
        }
    }
}
