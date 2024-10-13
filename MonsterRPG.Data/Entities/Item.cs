using MonsterRPG.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MonsterRPG.Data.Entities
{
    [Table("Item")]
    public class Item
    {
        public int Id { get; set; }

        public virtual TypeOfItem TypeOfItem { get; set; }

        public virtual Inventar Inventar { get; set; }

        public virtual Shop Shop { get; set; }

        public string Name { get; set; }

        public string Info  { get; set; }

        public int Damage { get; set; }

        public int Protection { get; set; }

        public int Cost { get; set; }

        public int CountItem { get; set; }

        public bool IsUseItem   { get; set; }

    }
}
