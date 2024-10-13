using MonsterRPG.Data.Entities;
using System.Data.Entity;

namespace MonsterRPG.API
{
    public class MonsterContext : DbContext
    {
        private const string _connString = "Data Source=ALEX;Initial Catalog=MonsterDb;Persist Security Info=True;User ID=Use1;Password=***********;Encrypt=True;Trust Server Certificate=True";
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
