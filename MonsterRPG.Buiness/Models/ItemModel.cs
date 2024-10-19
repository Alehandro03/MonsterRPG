using MonsterRPG.Data.Entities;
using MonsterRPG.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterRPG.Buiness.Models
{
    public class ItemModel
    {
        public int? Id { get; set; }
        public  TypeOfItem TypeOfItem { get; set; }
        public  Inventar Inventar { get; set; }
        public  Shop Shop { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public int Damage { get; set; }
        public int Protection { get; set; }
        public int Cost { get; set; }
        public int CountItem { get; set; }
        public bool IsUseItem { get; set; }
    }
}
