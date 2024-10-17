using MonsterRPG.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterRPG.Data.Entities
{
    [Table("Personage")]
    public class Personage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Hp { get; set; }
        public int MinHp { get; set; }
        public int Attack { get; set; }
        public int Armor { get; set; }
        public int Cash { get; set; }
        public int NumberPersonage { get; set; }
        public string WarCry { get; set; }
        public string DeadCry   { get; set; }
        public bool GoPVP { get; set; }
        public virtual Inventar Inventar { get; set; }
        public virtual TypeOfMonster TypeOfMonster { get; set; }
    }
}
