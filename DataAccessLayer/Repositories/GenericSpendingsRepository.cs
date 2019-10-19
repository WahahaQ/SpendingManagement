using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
	public class GenericSpendingsRepository : GenericRepository<Spending>
	{
		public GenericSpendingsRepository(DbContext context) : base(context)
		{ }
	}
}