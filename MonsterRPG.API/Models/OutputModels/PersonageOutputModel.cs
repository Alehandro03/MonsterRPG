using MonsterRPG.Data.Entities;
using MonsterRPG.Data.Enum;

namespace MonsterRPG.API.Models
{
    public class PersonageOutputModel : PersonageSimpleOutputModel
    {
        public int? Id { get; set; }
        public int MinHp { get; set; }
        public bool GoPVP { get; set; }

    }
}
