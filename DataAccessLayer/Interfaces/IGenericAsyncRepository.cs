using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Interfaces
{
	interface IGenericAsyncRepository<TEntity> where TEntity : Entity
	{
		Task CreateAsync(TEntity item);
		Task<TEntity> GetItemAsync(TEntity item);
		Task<TEntity> GetItemAsync(Expression<Func<TEntity, bool>> predicate);
		Task<TEntity> GetItemByIdAsync(int id);
		Task<IEnumerable<TEntity>> GetItemsAsync();
		Task<IEnumerable<TEntity>> GetItemsAsync(Expression<Func<TEntity, bool>> predicate);
		Task RemoveAsync(TEntity item);
		Task UpdateAsync(TEntity item);
	}
}