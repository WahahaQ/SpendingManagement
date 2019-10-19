using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataAccessLayer;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using DTOLayer.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BusinessLogicLayer.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class SpendingsController : ControllerBase
	{
		#region Fields

		private readonly IGenericAsyncRepository<Spending> _repository;
		private readonly IMapper _mapper;

		#endregion Fields

		public SpendingsController(IGenericAsyncRepository<Spending> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		#region Methods

		[HttpGet]
		public async Task<IEnumerable<Spending>> GetSpendingsAsync()
		{
			return await _repository.GetItemsAsync();
		}

		// Task<IEnumerable<TEntity>> GetItemsAsync(Expression<Func<TEntity, bool>> predicate);
		// Task<TEntity> GetItemByIdAsync(int id);
		// Task<TEntity> GetItemAsync(TEntity item);
		// Task<TEntity> GetItemAsync(Expression<Func<TEntity, bool>> predicate);
		// Task CreateAsync(TEntity item);
		// Task UpdateAsync(TEntity item);
		// Task RemoveAsync(TEntity item);

		#endregion Methods
	}
}