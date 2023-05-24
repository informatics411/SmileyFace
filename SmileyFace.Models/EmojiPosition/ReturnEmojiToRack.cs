using System;
namespace SmileyFace.Models.EmojiPosition
{
	public class ReturnEmojiToRack
	{
		public ReturnEmojiToRack()
		{
		}
		public int Itself { get; set; }
        public int EmojiRow { get; set; }
        public int EmojiColumn { get; set; }
        public int EmojiPrevious { get; set; }
        public int EmojiNext { get; set; }
    }
}

