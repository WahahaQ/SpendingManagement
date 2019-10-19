using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
	public class GenericUsersRepository : GenericRepository<User>
	{
		public GenericUsersRepository(DbContext context) : base(context)
		{ }
	}
}