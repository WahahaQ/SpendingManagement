using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
	public class SpendingsRepository : GenericAsyncRepository<Spending>
	{
		public SpendingsRepository(DbContext context) : base(context)
		{ }
	}
}