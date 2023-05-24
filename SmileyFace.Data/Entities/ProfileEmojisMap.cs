using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmileyFace.Data.Entities
{
    public class ProfileEmojisMap
	{

    [Key]
    public int Id { get; set; }

    [ForeignKey("ProfileSession")]
    public int ProfileSessionId { get; set; }

    public List<EmojisCluster> EmojisClusters { get; set; } = new List<EmojisCluster>();
	}
}

