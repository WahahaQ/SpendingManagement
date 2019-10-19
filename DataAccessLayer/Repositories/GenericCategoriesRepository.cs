using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
	public class GenericCategoriesRepository : GenericRepository<Category>
	{
		public GenericCategoriesRepository(DbContext context) : base(context)
		{ }
	}
}