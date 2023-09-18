using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Proje_OPP.Context
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}
	}
}
