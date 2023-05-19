using System;
namespace SmileyFace.Data.Entities
{
	public class Emoji
	{
		public Emoji()
		{
		}

		public int Id { get; set; }
		public string EmojiUnicode { get; set; }
		public string EmojiMeaning { get; set; }
		public string EmojiGenre { get; set; }
		public int EmojiLocation { get; set; }
		public int NextEmoji { get; set; }

		public int EmojiRank { get; set; }


    }
}

