using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
	public class TagsRepository : GenericRepository<Tag>
	{
		public TagsRepository(DbContext context) : base(context)
		{ }
	}
}