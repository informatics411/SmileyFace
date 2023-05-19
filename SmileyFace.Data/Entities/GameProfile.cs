using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmileyFacePOC.Data.Entities
{
	public class GameProfile
	{
		public GameProfile()
		{
		}

		public int Id { get; set; }
		[ForeignKey("SessionProfile")]	
		public int SessionProfileId { get; set; }
		public List<Single> SinglesList { get; set; } = new List<Single>();

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

