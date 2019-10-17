using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories
{
	public class CategoriesRepository : GenericAsyncRepository<Category>
	{
		public CategoriesRepository(DbContext context) : base(context)
		{ }
	}
}