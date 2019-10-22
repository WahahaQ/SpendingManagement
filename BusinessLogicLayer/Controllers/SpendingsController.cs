using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using DTOLayer.DTOs;
using AutoMapper;

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
		public async Task<IEnumerable<SpendingDTO>> GetSpendingsAsync()
		{
			IEnumerable<Spending> spendings = await _repository.GetItemsAsync();
			return _mapper.Map<List<SpendingDTO>>(spendings);
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