using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmileyFace.Data.Entities
{
	public class ProfileIdeaMap
	{
		public ProfileIdeaMap()
		{
		}
        [Key]
		public int Id { get; set; }
		[ForeignKey("ProfileSession")]	
		public int ProfileSessionId { get; set; }
		public List<IdeaChain> IdeaChains { get; set; } = new List<IdeaChain>();

	}

}

