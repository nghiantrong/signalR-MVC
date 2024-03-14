using Microsoft.EntityFrameworkCore;

namespace Activity6_SignalRLab.Models
{
	public class ApplicationDBContext : DbContext
	{
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : 
			base(options)
		{
		}
		public virtual DbSet<Products> Products { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Other configurations...

			modelBuilder.Entity<Products>()
				.Property(p => p.UnitPrice)
				.HasColumnType("decimal(18,2)"); // Adjust precision and scale as needed

			// Other configurations...
		}
	}
}
