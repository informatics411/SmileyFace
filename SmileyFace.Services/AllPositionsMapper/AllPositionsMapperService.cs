using System;
using SmileyFace.Data;

namespace SmileyFace.Services.AllPositionsMapper
{
	public class AllPositionsMapperService : IAllPositionsMapperService
	{
		 private readonly ApplicationDbContext _dbContext;
    	public AllPositionsMapperService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
		public AllPositionsMapperService()
		{

			//Create new grid
			//Update grid after ChooseEmoji, PositionEmoji
			//Save grid
			//
		}
	}
}

