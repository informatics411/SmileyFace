﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmileyFace.Data.Entities
{
	public class ProfileSessionEntity
	{
		public ProfileSessionEntity()
		{
		}
			[Key]
			public int Id { get; set; }
			[ForeignKey("AspNetUsers")]
			public string IdentityUserId { get; set; }
			public string UserEmoji { get; set; } //Emoji avatar for user
			public List<ProfileEmojisMapEntity> EmojisMaps { get; set; }
    }
}
