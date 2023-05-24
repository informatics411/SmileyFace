using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmileyFace.Data;
using SmileyFace.Data.Entities;
using SmileyFace.Models.Emoji;
using SmileyFace.Models.EmojiPosition;

namespace SmileyFace.Services.Emoji
{
    public class EmojiService : IEmojiService
    {
        private readonly ApplicationDbContext _dbContext;

        public EmojiService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<ChooseEmoji>> ChooseEmojiAsync(ChooseEmoji chooseEmoji)
        {
            var emojiEntity = new EmojiEntity
            {
                Itself = chooseEmoji.EmojiItself,
                Meaning = chooseEmoji.EmojiMeaning
            };

            _dbContext.Emojis.Add(emojiEntity);
            await _dbContext.SaveChangesAsync();

            return new List<ChooseEmoji> { chooseEmoji };
        }

        public async Task<bool> EmojiUpdateAsync(UpdateEmoji request)
        {
            var emoji = await _dbContext.Emojis.FirstOrDefaultAsync(e => e.Itself == request.Itself);

            if (emoji == null)
                return false;

            emoji.AltGenre1 = request.AltGenre1;
            emoji.Alt1Meaning = request.Alt1Meaning;
            emoji.Alt2Meaning = request.Alt2Meaning;
            emoji.Alt3Meaning = request.Alt3Meaning;

            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<EmojiEntity>> FindByEmojiItselfAsync(ListEmojiDetail request)
        {
            var emoji = await _dbContext.Emojis.FindAsync(request.Itself);

            if (emoji == null)
                return null;

            emoji.AltGenre1 = request.AltGenre1;
            emoji.Alt1Meaning = request.Alt1Meaning;
            emoji.Alt2Meaning = request.Alt2Meaning;
            emoji.Alt3Meaning = request.Alt3Meaning;

            await _dbContext.SaveChangesAsync();
            return new List<EmojiEntity> { emoji };
        }

        public async Task<IEnumerable<ListEmojiDetail>> ListEmojiiDetailAsync(ListEmojiDetail emojiDetail)
        {
            var emojis = await _dbContext.Emojis.ToListAsync();

            // Apply filtering based on the emoji detail properties
            if (!string.IsNullOrEmpty(emojiDetail.AltGenre1))
            {
                emojis = emojis.Where(e => e.AltGenre1 == emojiDetail.AltGenre1).ToList();
            }

            if (!string.IsNullOrEmpty(emojiDetail.Alt1Meaning))
            {
                emojis = emojis.Where(e => e.Alt1Meaning == emojiDetail.Alt1Meaning).ToList();
            }

            if (!string.IsNullOrEmpty(emojiDetail.Alt2Meaning))
            {
                emojis = emojis.Where(e => e.Alt2Meaning == emojiDetail.Alt2Meaning).ToList();
            }

            if (!string.IsNullOrEmpty(emojiDetail.Alt3Meaning))
            {
                emojis = emojis.Where(e => e.Alt3Meaning == emojiDetail.Alt3Meaning).ToList();
            }

            return emojis.Select(e => new ListEmojiDetail
            {
                Itself = e.Itself,
                AltGenre1 = e.AltGenre1,
                Alt1Meaning = e.Alt1Meaning,
                Alt2Meaning = e.Alt2Meaning,
                Alt3Meaning = e.Alt3Meaning
            });
        }
    }
}
