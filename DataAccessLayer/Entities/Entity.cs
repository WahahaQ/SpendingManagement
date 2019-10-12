using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
	public class Entity
	{
		[Key]
		public int Id { get; set; }
	}
}