using System;
using System.Threading.Tasks;
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

        public async Task<bool> AssignEmojiSpaceOnMapAsync(AssignEmojiSpaceOnMap request)
        {
            var placeEmoji = new EmojiPositionEntity
            {
                EmojiItself = request.EmojiItself,
                Row = request.EmojiRow,
                Column = request.EmojiColumn
            };

            _dbContext.EmojiPositions.Add(placeEmoji);

            var numberOfChanges = await _dbContext.SaveChangesAsync();
            return numberOfChanges == 1;
        }

        public async Task<bool> SetEmojiDirectionAsync(SetEmojiDirection request)
        {
            var emojiPosition = await _dbContext.EmojiPositions.FindAsync(request.EmojiId);

            if (emojiPosition == null)
            {
                // Handle the case where the emoji position does not exist
                return false;
            }

            if (emojiPosition.Direction != null)
            {
                // The emoji already has a direction assigned
                return false;
            }

            emojiPosition.Direction = request.EmojiDirection;

            var numberOfChanges = await _dbContext.SaveChangesAsync();
            return numberOfChanges == 1;
        }

        public Task<bool> AssignEmojiSpaceOnMapAsync(ChooseEmoji chooseEmoji)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ReturnEmojiToRackAsync(ReturnEmojiToRack returnEmoji)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ReturnEmojiToRackAsnc(ReturnEmojiToRack returnEmoji)
        {
            throw new NotImplementedException();
        }
    }
}
