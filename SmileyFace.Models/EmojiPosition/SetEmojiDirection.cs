using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace SmileyFace.Models.Emoji
{
	public class SetEmojiDirection
	{
		public SetEmojiDirection()
		{
		}
        [ForeignKey("Emoji")]
        public int emojiId { get; set; }

        [ForeignKey("EmojiPosition")]
        public int Direction { get; set; }

		[ForeignKey("EmojiPositionLinkedNode")]
		public int EmojiNode { get; set; }

        public int EmojiId { get => emojiId; set => emojiId = value; }
        public int EmojiId1 { get => emojiId; set => emojiId = value; }
    }
}

