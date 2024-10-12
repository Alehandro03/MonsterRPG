using MonsterRPG.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MonsterRPG.Data.Entities
{
    public class Item
    {
        public int Id { get; set; }

        public TypeOfItem TypeOfItem { get; set; }

        public List<Inventar> Inventars { get; set; }

        public string Name { get; set; }

        public string Info  { get; set; }

        public int Damage { get; set; }

        public int Protection { get; set; }

        public int Cost { get; set; }

        public int CountItem { get; set; }

        public bool IsUseItem   { get; set; }

    }
}
