using MonsterRPG.Buiness.Models;
using MonsterRPG.Buiness.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterRPG.Buiness.Services
{
    public class UserService : IUserService
    {
        public void ChangeUserNickName(int id, UserModel user, PersonageModel personage)
        {
            throw new NotImplementedException();
        }

        public void ChangeUserPersonage(int id, UserModel user, PersonageModel personage)
        {
            throw new NotImplementedException();
        }

        public UserModel DeleteUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public UserModel GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserModel> GetUsers()
        {
            throw new NotImplementedException();
        }

        public int RegistrationUser(UserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
