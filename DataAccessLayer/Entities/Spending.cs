using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
	[Table("Spendings")]
	public class Spending : Entity
	{
		[Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
		[StringLength(24, ErrorMessage = "Name can't be longer than 24 characters")]
		public string Name { get; set; }

		[Required(AllowEmptyStrings = false, ErrorMessage = "Description is required")]
		[StringLength(256, ErrorMessage = "Description can't be longer than 256 characters")]
		public string Description { get; set; }

		[Required(AllowEmptyStrings = false, ErrorMessage = "Creation time is required")]
		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
		public DateTime CreationTime { get; set; }

		[ForeignKey("Category")]
		public int CategoryId { get; set; }
		public Category Category { get; set; }

		public ICollection<Tag> Tags { get; set; }
	}
}