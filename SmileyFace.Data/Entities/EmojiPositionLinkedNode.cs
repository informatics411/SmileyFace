using System;
using System.ComponentModel.DataAnnotations;

namespace SmileyFace.Data.Entities
{
	public class EmojiPositionLinkedNode
	{
		public EmojiPositionLinkedNode()
		{
		}
		[Key]
        public int Id { get; set; }
        public int? NextId { get; set; }
        public int? PreviousId { get; set; }
    }
}

