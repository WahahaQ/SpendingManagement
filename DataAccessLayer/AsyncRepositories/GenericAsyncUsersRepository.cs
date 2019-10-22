using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.AsyncRepositories
{
	public class GenericAsyncUsersRepository : GenericAsyncRepository<User>
	{
		public GenericAsyncUsersRepository(DbContext context) : base(context)
		{ }
	}
}