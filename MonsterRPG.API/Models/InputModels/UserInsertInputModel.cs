using MonsterRPG.Data.Entities;

namespace MonsterRPG.API.Models.InputModels
{
    public class UserInsertInputModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public Personage Personage { get; set; }
    }
}
