using System;
namespace SmileyFace.Data.Entities
{
    public class AllPositionsMapper

    {
        private int[,] board;
        private int rows;
        private int columns;

        public AllPositionsMapper(int numRows, int numColumns)
        {
            rows = numRows;
            columns = numColumns;
            board = new int[rows, columns];
        }

        public int GetCellValue(int row, int column)
        {
            return board[row, column];
        }

        public void SetCellValue(int row, int column, int value)
        {
            board[row, column] = value;
        }
    }
}

