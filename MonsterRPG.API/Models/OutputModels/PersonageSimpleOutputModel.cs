using MonsterRPG.Data.Entities;
using MonsterRPG.Data.Enum;

namespace MonsterRPG.API.Models
{
    public class PersonageSimpleOutputModel
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Armor { get; set; }
        public int Cash { get; set; }
        public int NumberPersonage { get; set; }
        public string WarCry { get; set; }
        public string DeadCry { get; set; }
        public Inventar Inventar { get; set; }
        public TypeOfMonster TypeOfMonster { get; set; }
    }
}
