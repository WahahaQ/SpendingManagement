using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
	[Table("Tags")]
	public class Tag : Entity
	{
		[MaxLength(24)]
		[Required(AllowEmptyStrings = false)]
		public string Name { get; set; }
	}
}