using System;
namespace SmileyFace.Models.Emoji	
{
	public class SeeEmojisKeyboard //Unplayed emojis in bag
	{
		public SeeEmojisKeyboard()
		{
		}

		public class EmojisKeyboard
		{
            //code for seeing Emojis Keyboard?
            //public static string? ChooseEmoji1
            //{
            //    get
            //    {
            //    }
            //}

            //code for seeing Emojis Keyboard
            public void SetChooseEmoji(string? value)
            {
            }

            public bool ChooseEmoji => !string.IsNullOrEmpty(EmojiId);

            public string? EmojiId { get; private set; }
        }
	}
}

