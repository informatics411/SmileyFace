using System;
namespace SmileyFace.Models.Emoji
{
	public class PlaceEmoji
	{
		public PlaceEmoji()
		{
		}
   
        public int EmojiRow { get; set; }
        public int EmojiColumn { get; set; }
		public int EmojiPrevious { get; set; }
		public int EmojiNext { get; set; }
    }
}

