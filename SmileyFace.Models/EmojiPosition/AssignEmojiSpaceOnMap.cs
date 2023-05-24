using System;
namespace SmileyFace.Models.Emoji
{
	public class AssignEmojiSpaceOnMap
	{
		public AssignEmojiSpaceOnMap()
		{
		}
        // [ForeignKey("Emoji")]
		public int EmojiItself { get; set; }
        public int? EmojiRow { get; set; }
        public int? EmojiColumn { get; set; }
		// [ForeignKey("EmojiPositionLinkedNode")]
		public int? EmojiPrevious { get; set; }
		public int? EmojiNext { get; set; }
    }
}

