using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmileyFace.Data.Entities
{
	public class ProfileSession
	{
		public ProfileSession()
		{
		}
			[Key]
			public int Id { get; set; }
			[ForeignKey("AspNetUsers")]
			public string IdentityUserId { get; set; }
			public string UserEmoji { get; set; } //Emoji avatar for user
			public List<ProfileIdeasMap> IdeasMapped { get; set; }
    }
}

