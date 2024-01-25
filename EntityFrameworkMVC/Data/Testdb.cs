using EntityFrameworkMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkMVC.Data
{
    public class Testdb : DbContext
    {
        public Testdb(DbContextOptions<Testdb> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
