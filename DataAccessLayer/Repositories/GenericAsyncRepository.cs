using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DataAccessLayer.Repositories
{
	public abstract class GenericAsyncRepository<TEntity> : GenericRepository<TEntity>, IGenericAsyncRepository<TEntity> where TEntity : Entity
	{
		public GenericAsyncRepository(DbContext context) : base(context)
		{ }

		#region PublicMethods

		virtual async public Task<IEnumerable<TEntity>> GetItemsAsync()
		{
			return await DbSet.AsNoTracking()
					 .ToListAsync();
		}

		virtual async public Task<IEnumerable<TEntity>> GetItemsAsync(Expression<Func<TEntity, bool>> predicate)
		{
			return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
		}

		virtual async public Task<TEntity> GetItemByIdAsync(int id)
		{
			return await DbSet.FindAsync(id);
		}

		virtual async public Task<TEntity> GetItemAsync(TEntity item)
		{
			return await DbSet.FindAsync(item);
		}

		virtual async public Task<TEntity> GetItemAsync(Expression<Func<TEntity, bool>> predicate)
		{
			return await DbSet.AsNoTracking().Where(predicate).FirstOrDefaultAsync();
		}

		virtual async public Task CreateAsync(TEntity item)
		{
			DbSet.Add(item);
			await Context.SaveChangesAsync();
		}

		virtual async public Task UpdateAsync(TEntity item)
		{
			DbSet.Update(item);
			await Context.SaveChangesAsync();
		}

		virtual async public Task RemoveAsync(TEntity item)
		{
			DbSet.Remove(item);
			await Context.SaveChangesAsync();
		}

		#endregion PublicMethods
	}
}