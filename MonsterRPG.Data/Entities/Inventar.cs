using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterRPG.Data.Entities
{
    [Table("Inventar")]
    public class Inventar
    {
        public int Id { get; set; } // Это и явл первич ключ

        public virtual ICollection<Item> Items { get; set; } //LazyLoading
    }
}
