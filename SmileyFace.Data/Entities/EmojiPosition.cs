﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmileyFace.Data.Entities
{
	public class EmojiPosition
	{
		public EmojiPosition()
		{
		}
		public int Id { get; set; }
		[ForeignKey("Emoji")]
		public int EmojiId { get; set; }
		public int Row { get; set; }
		public int Column { get; set; }
    }
}
