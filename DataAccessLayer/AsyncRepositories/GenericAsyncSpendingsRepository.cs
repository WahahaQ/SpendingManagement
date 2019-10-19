using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.AsyncRepositories
{
	public class GenericAsyncSpendingsRepository : GenericAsyncRepository<Spending>
	{
		public GenericAsyncSpendingsRepository(DbContext context) : base(context)
		{ }
	}
}