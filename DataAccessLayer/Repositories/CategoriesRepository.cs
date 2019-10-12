using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
	public class CategoriesRepository : GenericRepository<Category>
	{
		public CategoriesRepository(DbContext context) : base(context)
		{ }
	}
}