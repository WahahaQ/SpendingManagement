using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
	public class TagsRepository : GenericAsyncRepository<Tag>
	{
		public TagsRepository(DbContext context) : base(context)
		{ }
	}
}