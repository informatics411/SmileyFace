using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmileyFace.Data.Entities
{
	public class IdeaMapProfile
	{
		public IdeaMapProfile()
		{
		}
        [Key]
		public int Id { get; set; }
		[ForeignKey("SessionProfile")]	
		public int SessionProfileId { get; set; }
		public List<IdeaChain> IdeaChains { get; set; } = new List<IdeaChain>();

	}
    //public class Grid

    //{
    //    private int[,] board;
    //    private int rows;
    //    private int columns;

    //    public Grid(int numRows, int numColumns)
    //    {
    //        rows = numRows;
    //        columns = numColumns;
    //        board = new int[rows, columns];
    //    }

    //    public int GetCellValue(int row, int column)
    //    {
    //        return board[row, column];
    //    }

    //    public void SetCellValue(int row, int column, int value)
    //    {
    //        board[row, column] = value;
    //    }
    //}
}

