using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;

namespace DataAccessLayer.Repositories
{
	public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : Entity
	{
		#region Fields

		public DbContext Context { get; set; }
		public DbSet<TEntity> DbSet { get; set; }

		#endregion Fields

		public GenericRepository(DbContext context)
		{
			Context = context;
			DbSet = context.Set<TEntity>();
		}

		#region PublicMethods

		virtual public IEnumerable<TEntity> GetItems()
		{
			return DbSet.AsNoTracking().ToList();
		}

		virtual public IEnumerable<TEntity> GetItems(Func<TEntity, bool> predicate)
		{
			return DbSet.AsNoTracking().Where(predicate).ToList();
		}

		virtual public TEntity GetItemById(int id)
		{
			return DbSet.Find(id);
		}

		virtual public TEntity GetItem(TEntity item)
		{
			return DbSet.Find(item);
		}

		virtual public TEntity GetItem(Func<TEntity, bool> predicate)
		{
			return DbSet.AsNoTracking().Where(predicate).FirstOrDefault();
		}

		virtual public void Create(TEntity item)
		{
			DbSet.Add(item);
			Context.SaveChanges();
		}

		virtual public void Update(TEntity item)
		{
			Context.Entry(item).State = EntityState.Modified;
			Context.SaveChanges();
		}

		virtual public void Remove(TEntity item)
		{
			DbSet.Remove(item);
			Context.SaveChanges();
		}

		#endregion PublicMethods
	}
}