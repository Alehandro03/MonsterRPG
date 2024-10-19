using MonsterRPG.Data.Entities;
using MonsterRPG.Data.Enum;

namespace MonsterRPG.API.Models.InputModels
{
    public class PersonageInsertInputModel
    {
        public string Name { get; set; }
        public string WarCry { get; set; }
        public string DeadCry { get; set; }
        public TypeOfMonster TypeOfMonster { get; set; }
    }
}
