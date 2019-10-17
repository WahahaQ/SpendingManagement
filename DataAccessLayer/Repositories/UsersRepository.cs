using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories
{
	public class UsersRepository : GenericAsyncRepository<User>
	{
		public UsersRepository(DbContext context) : base(context)
		{ }
	}
}