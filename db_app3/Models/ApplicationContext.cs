using Microsoft.EntityFrameworkCore;

namespace db_app3.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //5 parts:
            //Host - localhost
            //Port - 5432
            //Database - dbName
            //Username
            //Password
            optionsBuilder.UseNpgsql(
                "Host=localhost;Port=5432;Database=users_database;Username=postgres;Password=P@ssw0rd");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
            
        }
    }
}