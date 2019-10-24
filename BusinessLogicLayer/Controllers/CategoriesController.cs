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
	public class CategoriesController : Controller
	{
		#region Fields

		private readonly IGenericAsyncRepository<Category> _repository;
		private readonly IMapper _mapper;

		#endregion Fields

		public CategoriesController(IGenericAsyncRepository<Category> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		#region Methods

		[HttpGet]
		public async Task<IEnumerable<CategoryDTO>> GetCategories()
		{
			IEnumerable<Category> categories = await _repository.GetItemsAsync();
			return _mapper.Map<List<CategoryDTO>>(categories);
		}

		[HttpGet("{id}")]
		public async Task<CategoryDTO> GetCategoryById(int id)
		{
			if (id < 0)
			{
				return null;
			}

			Category category = await _repository.GetItemByIdAsync(id);
			return _mapper.Map<CategoryDTO>(category);
		}

		[HttpPost]
		public async Task<IActionResult> CreateCategory(CategoryDTO category)
		{
			if (category == null)
			{
				return BadRequest("Not a valid category id");
			}

			Category itemToCreate = _mapper.Map<Category>(category);
			await _repository.CreateAsync(itemToCreate);
			return Ok();
		}

		[HttpPut]
		public async Task<IActionResult> UpdateCategory(CategoryDTO category)
		{
			if (category == null)
			{
				return BadRequest("Not a valid category id");
			}

			Category itemToUpdate = _mapper.Map<Category>(category);
			await _repository.UpdateAsync(itemToUpdate);
			return Ok();
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteCategory(CategoryDTO category)
		{
			if (category == null)
			{
				return BadRequest("Not a valid category id");
			}

			Category itemToDelete = _mapper.Map<Category>(category);
			await _repository.RemoveAsync(itemToDelete);
			return Ok();
		}

		#endregion Methods
	}
}