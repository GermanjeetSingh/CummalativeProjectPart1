using Microsoft.EntityFrameworkCore;

namespace SchoolWebApp.Models
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext()
        {
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=schooldb;user=root;password=system");
        }
    }
}
