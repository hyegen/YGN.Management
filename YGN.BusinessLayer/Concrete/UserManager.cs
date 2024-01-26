using Entities.Concrete;
using YGN.BusinessLayer.Abstract;
using YGN.DataAccesLayer.Abstract;

namespace YGN.BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void AddUser(User user)
        {
            _userDal.Add(user);
        }

        public int GetUser()
        {
            var user = _userDal.GetUsers();
            return user;
        }

        public bool Login(string userName, string password)
        {
            var loginValue = _userDal.LoginByUsernameAndPassword(userName, password);
            return loginValue;
        }
    }
}
