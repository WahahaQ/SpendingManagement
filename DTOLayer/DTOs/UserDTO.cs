using System.Collections.Generic;

namespace DTOLayer.DTOs
{
	public class UserDTO
	{
		public string Email { get; set; }

		public string Sha256Password { get; set; }

		public ICollection<SpendingDTO> Spendings { get; set; }
	}
}