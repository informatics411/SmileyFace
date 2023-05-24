using System;
using SmileyFace.Models.Emoji;
using SmileyFace.Models.EmojiPosition;

namespace SmileyFace.Services.EmojiPosition
{
	public interface IEmojiPositionService
	{
        Task<bool> AssignEmojiSpaceOnMapAsync(ChooseEmoji chooseEmoji);
        Task<bool> ReturnEmojiToRackAsnc(ReturnEmojiToRack returnEmoji);
        Task<bool> SetEmojiDirectionAsync (SetEmojiDirection emojiDirection);
    }
}

