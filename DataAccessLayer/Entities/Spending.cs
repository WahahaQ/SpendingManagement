using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
	[Table("Spendings")]
	public class Spending : Entity
	{
		[MaxLength(24)]
		[Required(AllowEmptyStrings = false)]
		public string Name { get; set; }

		[MaxLength(256)]
		[Required(AllowEmptyStrings = false)]
		public string Description { get; set; }

		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
		public DateTime CreationTime { get; set; }

		[ForeignKey("Category")]
		public int CategoryId { get; set; }
		public Category Category { get; set; }

		public ICollection<Tag> Tags { get; set; }
	}
}