using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.AsyncRepositories
{
	public abstract class GenericAsyncRepository<TEntity> : IGenericAsyncRepository<TEntity> where TEntity : Entity
	{
		#region Fields

		public DbContext Context { get; set; }
		public DbSet<TEntity> DbSet { get; set; }

		#endregion Fields

		public GenericAsyncRepository(DbContext context)
		{
			Context = context;
			DbSet = context.Set<TEntity>();
		}

		#region Methods

		virtual async public Task<IEnumerable<TEntity>> GetItemsAsync()
		{
			return await DbSet.AsNoTracking().ToListAsync();
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
			await DbSet.AddAsync(item);
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

		#endregion Methods
	}
}