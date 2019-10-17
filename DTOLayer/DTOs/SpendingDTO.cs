using System;
using System.Collections.Generic;

namespace DTOLayer.DTOs
{
	public class SpendingDTO
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime CreationTime { get; set; }
		public int CategoryId { get; set; }
		public ICollection<TagDTO> Tags { get; set; }
	}
}