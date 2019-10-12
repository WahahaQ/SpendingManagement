using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
	[Table("Users")]
	public class User : Entity
	{
		[MaxLength(64)]
		[Required(AllowEmptyStrings = false)]
		[RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
		public string Email { get; set; }

		[MaxLength(256)]
		[Required(AllowEmptyStrings = false)]
		public string Sha256Password { get; set; }

		public ICollection<Spending> Spendings { get; set; }
	}
}