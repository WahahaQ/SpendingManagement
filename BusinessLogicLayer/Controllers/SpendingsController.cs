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
		public async Task<IEnumerable<SpendingDTO>> GetSpendings()
		{
			IEnumerable<Spending> spendings = await _repository.GetItemsAsync();
			return _mapper.Map<List<SpendingDTO>>(spendings);
		}

		[HttpGet("{id}")]
		public async Task<SpendingDTO> GetSpendingById(int id)
		{
			if (id < 0)
			{
				return null;
			}

			Spending spending = await _repository.GetItemByIdAsync(id);
			return _mapper.Map<SpendingDTO>(spending);
		}

		[HttpPost]
		public async Task<IActionResult> CreateSpending(SpendingDTO spending)
		{
			if (spending == null)
			{
				return BadRequest("Not a valid spending id");
			}

			Spending itemToCreate = _mapper.Map<Spending>(spending);
			await _repository.CreateAsync(itemToCreate);
			return Ok();
		}

		[HttpPut]
		public async Task<IActionResult> UpdateSpending(SpendingDTO spending)
		{
			if (spending == null)
			{
				return BadRequest("Not a valid spending id");
			}

			Spending itemToUpdate = _mapper.Map<Spending>(spending);
			await _repository.UpdateAsync(itemToUpdate);
			return Ok();
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteSpending(SpendingDTO spending)
		{
			if (spending == null)
			{
				return BadRequest("Not a valid spending id");
			}

			Spending itemToDelete = _mapper.Map<Spending>(spending);
			await _repository.RemoveAsync(itemToDelete);
			return Ok();
		}

		#endregion Methods
	}
}