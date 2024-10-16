using MonsterRPG.Data.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace MonsterRPG.API.MonsterContext
{
    public class MonsterContext : DbContext
    {
        
        private const string _connString = "Data Source=ALEX;Initial Catalog=MonsterDb;Persist Security Info=True;User ID=Use1;Password=***********;Trust Server Certificate=True";
        public MonsterContext() : base (_connString)
        {
            
        }

  
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Personage> Personages { get; set; }
        public DbSet<Inventar> Inventars { get; set; }
        public DbSet<Shop> Shops { get; set; }


    }
}
