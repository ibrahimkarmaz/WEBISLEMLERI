using Microsoft.EntityFrameworkCore;
using Proje_OPP.Entity;

namespace Proje_OPP.Context
{
	public class DbContextOptions:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;database=DbNewOopCore;integrated security=true;");
		}

		public DbSet<Product> products { get; set; }
		public DbSet<Customer> customers { get; set; }
		public DbSet<Category> Categories { get; set; }
	}
}
