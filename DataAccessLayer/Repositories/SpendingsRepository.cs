using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
	public class SpendingsRepository : GenericRepository<Spending>
	{
		public SpendingsRepository(DbContext context) : base(context)
		{ }
	}
}