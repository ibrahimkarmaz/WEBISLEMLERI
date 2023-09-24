using Microsoft.EntityFrameworkCore;
using ProjeOOPDers1.Entity;
using System.Data.Common;

namespace ProjeOOPDers1.Context
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=DbNewOopCoreLecture;Trusted_Connection=True;");
		}

		public DbSet<Customer> Customers { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
	}
}
