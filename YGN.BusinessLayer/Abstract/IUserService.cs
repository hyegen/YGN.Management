using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGN.BusinessLayer.Abstract
{
    public interface IUserService
    {
        void AddUser(User user);
        bool GetUserByUserNameAndPassword(string userName,string password);
    }
}
