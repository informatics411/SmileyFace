using System;
namespace SmileyFace.Models.Emoji
{
	public class UpdateEmoji //Add AltGenre, AltMeaning
	{
		public UpdateEmoji()
		{
		}
		public string AltCategory1 { get; set; }
        public string? Alt1Meaning { get; set; }
        public string? Alt2Meaning { get; set; }
        public string? Alt3Meaning { get; set; }

    }
}

