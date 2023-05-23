using System;
namespace SmileyFace.Models.Emoji
{
	public class EmojiDetail
	{
		public EmojiDetail()
		{
		}
        public string Unicode { get; set; }
        public string Itself { get; set; }
        public string Genre { get; set; }
        public string? AltCategory1 { get; set; }
        public string Meaning { get; set; }
        public string? Alt1Meaning { get; set; }
        public string? Alt2Meaning { get; set; }
        public string? Alt3Meaning { get; set; }

    }
}

