using Microsoft.EntityFrameworkCore;

namespace CoreDepartman.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;database=CorePersonel;integrated security=true;");
        }
        public DbSet<Departmanlar> Departmanlars { get; set; }
        public DbSet<Personel> Personels { get; set; }
    }
}
