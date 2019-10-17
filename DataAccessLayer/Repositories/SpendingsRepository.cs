using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories
{
	public class SpendingsRepository : GenericAsyncRepository<Spending>
	{
		public SpendingsRepository(DbContext context) : base(context)
		{ }
	}
}