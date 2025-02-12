
using System.ComponentModel.DataAnnotations.Schema;


namespace MonsterRPG.Data.Entities
{
    [Table("Shop")]
    public class Shop
    {
        public int? Id { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
