using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmileyFace.Data.Entities
{
	public class Emoji
	{
		public Emoji()
		{
		}
		[Key]
		public int Id { get; set; }

        public string Unicode { get; set; }
        public string Itself { get; set; }
        public string Genre { get; set; }
        public string? AltCategory1 { get; set; }
        public string Meaning { get; set; }
        public string? Alt1Meaning { get; set; }
        public string? Alt2Meaning { get; set; }
        public string? Alt3Meaning { get; set; }

        public int? NodeId { get; set; }
        //region navigation properties [update
        public EmojiPositionLinkedNode Node { get; set; }


        //testing other ideas for how to capture useful data

        //# navigation properties [original
        //        public int CollectionId { get; set; }
        //        public IdeaChain Chain { get; set; }
        //        public int? PreviewId { get; set; }
        //        public Emoji Preview { get; set; }
        //        public int? Next { get; set; }
        //        public Emoji Next { get; set; }

        //v2s
        //public string? Alt4Meaning { get; set; }
        //public string? Alt5Meaning { get; set; }

        // public int Location { get; set; }
        // public bool IsNested { get; set; }  //in the nest...true signifies hasGuardian; false signifies Unnested, untethered idea on ideaMap
        // public int Direction { get; set; } //45• mapping up, right; 90• right,right; 135• right, down; 180 • down, down; 225• down, left; 270• left, left; 315• left, up; 360• up, up

        //[ForeignKey("IdeaMap")]
        //public int IsGuardian { get; set; } //is nest guardian
    }
}

