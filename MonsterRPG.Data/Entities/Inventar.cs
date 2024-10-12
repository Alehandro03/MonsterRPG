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
        public int Id { get; set; }

        public List<Item> Items { get; set; }
    }
}
