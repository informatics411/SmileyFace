using System;
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
        public EmojiService()
        {
        }
        public async Task<SmileyFace.Data.Entities.Emoji> ChooseEmojiAsync(ChooseEmoji request)
        {
            var chooseEmoji = new SmileyFace.Data.Entities.Emoji
            {
                Itself = request.EmojiItself,
                Meaning = request.EmojiMeaning,
            };

            var newEmoji = _dbContext.Emojis.Add(chooseEmoji).Entity;

            await _dbContext.SaveChangesAsync();
            return newEmoji;
        }

        public async Task<bool> EmojiUpdateAsync(UpdateEmoji request)
        {

            var Emoji = await GetEmoji().FindAsync(request.Itself);

            if (Emoji?.Itself != request.Itself)
                return false;

            Emoji.AltGenre1 = request.AltGenre1;
            Emoji.Alt1Meaning = request.Alt1Meaning;
            Emoji.Alt2Meaning = request.Alt2Meaning;
            Emoji.Alt3Meaning = request.Alt3Meaning;


            var numberOfChanges = await _dbContext.SaveChangesAsync();
            return numberOfChanges == 1;
        }

        private object GetEmoji()
        {
            return _dbContext.Emoji;
        }

        public async Task<IEnumerable<FindByEmojiItselfAsync>> FindByEmojiItself(ListEmojiDetail request)
      {
         var emoji = await _dbContext.Emojis.FindAsync(request.Itself);

            if (emoji?.Itself != request.Itself)
                
            
            emoji.AltGenre1 = request.AltGenre1;
            emoji.Alt1Meaning = request.Alt1Meaning;
            emoji.Alt2Meaning = request.Alt2Meaning;
            emoji.Alt3Meaning = request.Alt3Meaning;


            var numberOfChanges = await _dbContext.SaveChangesAsync();
            return numberOfChanges == 1;
        }

    




        //public async Task<IEnumerable<FindEmojiByMeaningAsync>> FindEmojiByMeaningAsync(string EmojiMeaning)//v2
        //{
        //}

        //public async Task<IEnumerable<FindEmojiByGenreAsync>>FindEmojiByGenreAsync(string EmojiGenre) //v2
        //{
        //}

        //public class EmojiKeyboard helper class? Keyboard appears, search by meaing, genre?
    }
}






