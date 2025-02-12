
using System.ComponentModel.DataAnnotations.Schema;


namespace MonsterRPG.Data.Entities
{
    [Table("Inventar")]// Делает таблв БД в ед числе 
    public class Inventar
    {
        public int? Id { get; set; } // Это и явл первич ключ
        public virtual ICollection<Item> Items { get; set; } //LazyLoading
    }
}
