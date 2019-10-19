using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.AsyncRepositories
{
	public class GenericAsyncUsersRepository : GenericAsyncRepository<User>
	{
		public GenericAsyncUsersRepository(DbContext context) : base(context)
		{ }
	}
}