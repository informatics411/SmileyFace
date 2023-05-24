using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmileyFace.Data.Entities
{
	public class EmojiPositionEntity
	{
		public EmojiPositionEntity()
		{
		}
		public int Id { get; set; }
		[ForeignKey("Emoji")]
		public int EmojiItself {get; set;}
		public int? Row { get; set; }
		public int? Column { get; set; }
        public int? Direction { get; set; }
    }
}

