using MonsterRPG.Buiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterRPG.Buiness.Services.Interface
{
    public interface IUserService
    {
        int RegistrationUser(UserModel model);
        void ChangeUserPersonage(int id, UserModel user, PersonageModel personage);
        void ChangeUserNickName(int id, UserModel user, PersonageModel personage);
        UserModel GetUserById(int id);
        List<UserModel> GetUsers();
        UserModel DeleteUser(UserModel user);

    }
}
