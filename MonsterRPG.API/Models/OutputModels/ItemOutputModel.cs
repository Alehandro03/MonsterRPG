using MonsterRPG.Data.Entities;
using MonsterRPG.Data.Enum;

namespace MonsterRPG.API.Models
{
    public class ItemOutputModel : ItemSimpleOutputModel
    {
        public int? Id { get; set; }
        public Inventar Inventar { get; set; }
        public Shop Shop { get; set; }
        public bool IsUseItem { get; set; }
    }
}
