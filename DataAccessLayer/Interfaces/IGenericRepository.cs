using System;
using System.Collections.Generic;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Interfaces
{
	public interface IGenericRepository<TEntity> where TEntity : Entity
	{
		void Create(TEntity item);
		TEntity GetItem(TEntity item);
		TEntity GetItem(Func<TEntity, bool> predicate);
		TEntity GetItemById(int id);
		IEnumerable<TEntity> GetItems();
		IEnumerable<TEntity> GetItems(Func<TEntity, bool> predicate);
		void Remove(TEntity item);
		void Update(TEntity item);
	}
}