using Ef_Core_Configurations.Configurations;
using Ef_Core_Configurations.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Ef_Core_Configurations.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= Localhost;Initial Catalog=ConfigureDB; Integrated Security = true;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarNumber> CarNumbers { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
