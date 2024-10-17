using MonsterRPG.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterRPG.Buiness.Models
{
    public class InventarModel
    {
        public int Id { get; set; } 
        public virtual ICollection<Item> Items { get; set; }
    }
}
