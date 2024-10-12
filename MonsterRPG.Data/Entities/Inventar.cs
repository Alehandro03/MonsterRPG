using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterRPG.Data.Entities
{
    public class Inventar
    {
        public int Id { get; set; }

        public List<Item> Items { get; set; }
    }
}
