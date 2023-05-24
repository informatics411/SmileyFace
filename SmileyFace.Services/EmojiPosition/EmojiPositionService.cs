using System;
using SmileyFace.Data;
using SmileyFace.Data.Entities;
using SmileyFace.Models.Emoji;
using SmileyFace.Models.EmojiPosition;

namespace SmileyFace.Services.EmojiPosition
{
    public class EmojiPositionService : IEmojiPositionService
    {
        private readonly ApplicationDbContext _dbContext;
        public EmojiPositionService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public EmojiPositionService()
        {
        }
        public async Task<bool> AssignEmojiSpaceOnMapAsync(AssignEmojiSpaceOnMap request) //assign position on board, an update to Emoji
        {

            var placeEmoji = new SmileyFace.Data.Entities.EmojiPosition()
            {
                EmojiItself = request.EmojiItself,
                Row = request.EmojiRow,
                Column = request.EmojiColumn,
            };
            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<Data.Entities.EmojiPosition> entityEntry = _dbContext.EmojiPositions.Add(placeEmoji);

            var numberOfChanges = await _dbContext.SaveChangesAsync();
            return numberOfChanges == 1;
        }

        public async Task<bool> SetEmojiDirectionAsync(SetEmojiDirection request) //give a direction to an emoji
        {
            var emojiPosition = new SmileyFace.Data.Entities.EmojiPosition();
            if (emojiPosition.Direction != null)
            { 
                HasDirection = false;
                var numberOfChanges = await _dbContext.SaveChangesAsync();
                return numberOfChanges == 1;
            }
            return true;
        }

        public Task<bool> AssignEmojiSpaceOnMapAsync(ChooseEmoji chooseEmoji)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ReturnEmojiToRackAsnc(ReturnEmojiToRack returnEmoji)
        {
            throw new NotImplementedException();
        }
    }
}
