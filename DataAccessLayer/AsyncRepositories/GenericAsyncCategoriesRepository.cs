using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Linq.Expressions;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.AsyncRepositories
{
	public class GenericAsyncCategoriesRepository : GenericAsyncRepository<Category>
	{
		public GenericAsyncCategoriesRepository(DbContext context) : base(context)
		{ }

		async public override Task<IEnumerable<Category>> GetItemsAsync()
		{
			return await DbSet.AsNoTracking().ToListAsync();
		}
	}
}