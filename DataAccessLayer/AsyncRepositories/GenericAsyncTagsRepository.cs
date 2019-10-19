using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.AsyncRepositories
{
	public class GenericAsyncTagsRepository : GenericAsyncRepository<Tag>
	{
		public GenericAsyncTagsRepository(DbContext context) : base(context)
		{ }
	}
}