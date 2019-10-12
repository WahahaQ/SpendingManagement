using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
	public class UsersRepository : GenericRepository<User>
	{
		public UsersRepository(DbContext context) : base(context)
		{ }
	}
}