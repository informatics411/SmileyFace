using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmileyFace.Data.Entities
{
    public class ProfileEmojisMapEntity
	{

    [Key]
    public int Id { get; set; }

    [ForeignKey("ProfileSession")]
    public int ProfileSessionId { get; set; }

    public List<EmojisClusterEntity> EmojisClusters { get; set; } = new List<EmojisClusterEntity>();
	}
}

