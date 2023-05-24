using System;
using SmileyFace.Models.Emoji;
using SmileyFace.Models.EmojiPosition;

namespace SmileyFace.Services.Emoji
{
	public interface IEmojiService
	{
    Task<bool> ChooseEmojiAsync(ChooseEmoji chooseEmoji);

    Task<IEnumerable<ListEmojiDetail>>ListEmojiiDetailAsync (ListEmojiDetail emojiDetail);
    Task<bool> EmojiUpdateAsync(UpdateEmoji request);
    Task<IEnumerable<FindByEmojiItselfAsync>> FindByEmojiItself(string Itself);

    }
}

