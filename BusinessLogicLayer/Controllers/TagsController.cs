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
	public class TagsController : Controller
	{
		#region Fields

		private readonly IGenericAsyncRepository<Tag> _repository;
		private readonly IMapper _mapper;

		#endregion Fields

		public TagsController(IGenericAsyncRepository<Tag> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		#region Methods

		[HttpGet]
		public async Task<IEnumerable<TagDTO>> GetTags()
		{
			IEnumerable<Tag> tags = await _repository.GetItemsAsync();
			return _mapper.Map<List<TagDTO>>(tags);
		}

		[HttpGet("{id}")]
		public async Task<TagDTO> GetTagById(int id)
		{
			if (id < 0)
			{
				return null;
			}

			Tag tag = await _repository.GetItemByIdAsync(id);
			return _mapper.Map<TagDTO>(tag);
		}

		[HttpPost]
		public async Task<IActionResult> CreateTag(TagDTO tag)
		{
			if (tag == null)
			{
				return BadRequest("Not a valid tag id");
			}

			Tag itemToCreate = _mapper.Map<Tag>(tag);
			await _repository.CreateAsync(itemToCreate);
			return Ok();
		}

		[HttpPut]
		public async Task<IActionResult> UpdateTag(TagDTO tag)
		{
			if (tag == null)
			{
				return BadRequest("Not a valid tag id");
			}

			Tag itemToUpdate = _mapper.Map<Tag>(tag);
			await _repository.UpdateAsync(itemToUpdate);
			return Ok();
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteTag(TagDTO tag)
		{
			if (tag == null)
			{
				return BadRequest("Not a valid tag id");
			}

			Tag itemToDelete = _mapper.Map<Tag>(tag);
			await _repository.RemoveAsync(itemToDelete);
			return Ok();
		}

		#endregion Methods
	}
}