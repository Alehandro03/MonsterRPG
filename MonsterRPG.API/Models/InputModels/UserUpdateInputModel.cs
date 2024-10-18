using MonsterRPG.Data.Entities;

namespace MonsterRPG.API.Models.InputModels
{
    public class UserUpdateInputModel
    {
        public string NickName { get; set; }
        public Personage Personage { get; set; }
    }
}
