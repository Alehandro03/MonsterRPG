using Microsoft.EntityFrameworkCore;
using MonsterRPG.Data.Entities;
using System.Data.Entity;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;




namespace MonsterRPG.Data.ConnectDb
{
    public class ApplicationContext : DbContext
    {
        public System.Data.Entity.DbSet<Inventar> Inventar { get; set; } = null;
        public System.Data.Entity.DbSet<Item> Item { get; set; }
        public System.Data.Entity.DbSet<Personage> Personage { get; set; }
        public System.Data.Entity.DbSet<Shop> Shop { get; set; }
        public System.Data.Entity.DbSet<User> User { get; set; }


        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
    }
}
