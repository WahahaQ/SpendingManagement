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
	public class UsersController : Controller
	{
		#region Fields

		private readonly IGenericAsyncRepository<User> _repository;
		private readonly IMapper _mapper;

		#endregion Fields

		public UsersController(IGenericAsyncRepository<User> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		#region Methods

		[HttpGet]
		public async Task<IEnumerable<UserDTO>> GetUsers()
		{
			IEnumerable<User> users = await _repository.GetItemsAsync();
			return _mapper.Map<List<UserDTO>>(users);
		}

		[HttpGet("{id}")]
		public async Task<UserDTO> GetUserById(int id)
		{
			if (id < 0)
			{
				return null;
			}

			User user = await _repository.GetItemByIdAsync(id);
			return _mapper.Map<UserDTO>(user);
		}

		[HttpPost]
		public async Task<IActionResult> CreateUser(UserDTO user)
		{
			if (user == null)
			{
				return BadRequest("Not a valid user id");
			}

			User itemToCreate = _mapper.Map<User>(user);
			await _repository.CreateAsync(itemToCreate);
			return Ok();
		}

		[HttpPut]
		public async Task<IActionResult> UpdateUser(UserDTO user)
		{
			if (user == null)
			{
				return BadRequest("Not a valid user id");
			}

			User itemToUpdate = _mapper.Map<User>(user);
			await _repository.UpdateAsync(itemToUpdate);
			return Ok();
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteUser(UserDTO user)
		{
			if (user == null)
			{
				return BadRequest("Not a valid user id");
			}

			User itemToDelete = _mapper.Map<User>(user);
			await _repository.RemoveAsync(itemToDelete);
			return Ok();
		}

		#endregion Methods
	}
}