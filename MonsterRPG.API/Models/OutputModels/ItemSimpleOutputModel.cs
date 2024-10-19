using MonsterRPG.Data.Entities;
using MonsterRPG.Data.Enum;

namespace MonsterRPG.API.Models
{
    public class ItemSimpleOutputModel
    {
        public TypeOfItem TypeOfItem { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public int Damage { get; set; }
        public int Protection { get; set; }
        public int Cost { get; set; }
        public int CountItem { get; set; }
    }
}
