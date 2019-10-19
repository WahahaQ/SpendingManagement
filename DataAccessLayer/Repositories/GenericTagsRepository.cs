using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
	public class GenericTagsRepository : GenericRepository<Tag>
	{
		public GenericTagsRepository(DbContext context) : base(context)
		{ }
	}
}