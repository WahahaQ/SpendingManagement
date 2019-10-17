using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
	public class CategoriesRepository : GenericAsyncRepository<Category>
	{
		public CategoriesRepository(DbContext context) : base(context)
		{ }
	}
}