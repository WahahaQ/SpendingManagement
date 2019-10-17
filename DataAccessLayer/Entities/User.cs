using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
	[Table("Users")]
	public class User : Entity
	{
		[Required(AllowEmptyStrings = false, ErrorMessage = "Email is required")]
		[StringLength(64, ErrorMessage = "Email can't be longer than 64 characters")]
		[RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email has the wrong format")]
		public string Email { get; set; }

		[Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
		[StringLength(256, ErrorMessage = "Password can't be longer than 256 characters")]
		public string Sha256Password { get; set; }

		public ICollection<Spending> Spendings { get; set; }
	}
}