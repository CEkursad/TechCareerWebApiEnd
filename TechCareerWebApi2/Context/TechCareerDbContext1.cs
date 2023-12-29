using Microsoft.EntityFrameworkCore;
using TechCareerWebApi2.Models.ORM;


namespace TechCareerWebApi2.Context
{
    public class TechCareerDbContext1 : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KURSAD;Database=TechCareerDb1; trusted_connection=true");
        }
        public DbSet<Employee1> Employees1 { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
