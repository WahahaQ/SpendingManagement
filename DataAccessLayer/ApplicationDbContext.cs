using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options) { }

		public DbSet<Tag> Tags { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Spending> Spendings { get; set; }
		public DbSet<User> Users { get; set; }
	}
}