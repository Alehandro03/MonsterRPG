using MonsterRPG.Data.Entities;
using System.Data.Entity;

namespace MonsterRPG.API
{
    public class MonsterContext : DbContext
    {
        private const string _connString = "qweqwewqewq";
        public MonsterContext() : base(_connString)
        { 
        
        
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Personage> Personages { get; set; }
        public DbSet<Inventar> Inventars { get; set; }
        public DbSet<Shop> Shops { get; set; }


    }
}
