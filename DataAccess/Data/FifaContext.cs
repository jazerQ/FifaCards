using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
	public class FifaContext : DbContext
	{
		public FifaContext(DbContextOptions options) : base(options) { }

		public DbSet<Skills> Skills { get; set; }
		public DbSet<FifaCard> Cards { get; set; } 
	}
}
