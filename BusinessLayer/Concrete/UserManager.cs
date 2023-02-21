using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void AddUser(User user)
        {
            _userDal.Add(user);
        }

        public void DeleteUser(User user)
        {
            _userDal.Delete(user);
        }

        public User GetUserById(int id)
        {
              return _userDal.Get(x => x.UserID == id);
        }

        public List<User> GetUserList()
        {
            return _userDal.List();
        }

        public void UpdateUser(User user)
        {
            _userDal.Update(user);
        }

        void IUserService.GetUserById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
