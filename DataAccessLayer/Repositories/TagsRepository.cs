using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories
{
	public class TagsRepository : GenericAsyncRepository<Tag>
	{
		public TagsRepository(DbContext context) : base(context)
		{ }
	}
}