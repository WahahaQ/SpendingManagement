using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
	[Table("Tags")]
	public class Tag : Entity
	{
		[Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
		[StringLength(24, ErrorMessage = "Name can't be longer than 24 characters")]
		public string Name { get; set; }
	}
}