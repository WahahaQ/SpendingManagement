using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
	public class UsersRepository : GenericAsyncRepository<User>
	{
		public UsersRepository(DbContext context) : base(context)
		{ }
	}
}