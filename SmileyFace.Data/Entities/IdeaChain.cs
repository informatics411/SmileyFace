using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmileyFace.Data.Entities
{
	public class IdeaChain
	{
		public IdeaChain()
		{
		}
		[Key]
		public int Id { get; set; }
		[ForeignKey("Emoji")]
		public int EmojiId { get; set; }
		public string EmojiString { get; set; } //Sentence-like catcatenation of intended Emoji meaning as used in cluster sequence
		public int EmojiInstanceLocation { get; set; }
		//public virtual List<int> EmojiNeighbors { get; set; }//adjacent emojis
		//public virtual ICollection<route> route { get; set; } //nextEmojiLocation + nextEmojiLocation + nextEmojiLocation?


		//An ideaString means a Location+Direction; location only means untethered, unnested, unrelated and perhaps even unknown
	}
}

