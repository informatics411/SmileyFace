﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmileyFace.Data.Entities
{
	public class SessionProfile
	{
		public SessionProfile()
		{
		}
			[Key]
			public int Id { get; set; }
			[ForeignKey("AspNetUsers")]
			public string IdentityUserId { get; set; }
			public string UserEmoji { get; set; } //Emoji avatar for user
			public List<IdeaMapProfile> IdeasMapped { get; set; }
	}
}

