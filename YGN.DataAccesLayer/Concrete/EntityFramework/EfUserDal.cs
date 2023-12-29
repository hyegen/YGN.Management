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
    public class EfUserDal : EfGenericRepositoryBase<User, YGNContext>, IUserDal
    {
        public bool Login(string userName, string password)
        {
            using (YGNContext context = new YGNContext())
            {
                var result =
                    from i in context.Users
                    where i.UserName == userName && i.Password == password
                    select i;
               
                return result.Any();
            }
        }
    }
}
