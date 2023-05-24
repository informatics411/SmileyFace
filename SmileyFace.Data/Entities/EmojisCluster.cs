using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmileyFace.Data.Entities

	//Now Subsumed By Linked List EmojiPositionLinkedNode?
{
	public class EmojisCluster
{
	public EmojisCluster()
	{
	}
	[Key]
	public int Id { get; set; }
	[ForeignKey("Emoji")]
	public int EmojiItself{ get; set; }
	public string EmojiMeaning { get; set; } //Sentence-like catcatenation of intended Emoji meaning as used in cluster sequence
	

        public class EmojiPositionLinkedNode
        {
               [Key]
        public int Id { get; set; }
        public int? NextId { get; set; }
        public int? PreviousId { get; set; }
        }
     
    }

    //public int [,] Row,Column { get; set; } //Remember: 1,1 is lowest, left most?
    //public virtual List<int> EmojiNeighbors { get; set; }//adjacent emojis

    //public ICollection<EmojiPosition> EmojiPositions { get; set; } //nextEmojiLocation + nextEmojiLocation + nextEmojiLocation?


    //An ideaString means a Location+Direction; location only means untethered, unnested, unrelated and perhaps even unknown

    //LinkedList
}

