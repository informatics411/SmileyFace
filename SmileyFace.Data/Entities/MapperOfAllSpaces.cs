
using System;
using System.ComponentModel.DataAnnotations;
namespace SmileyFace.Data.Entities

{
    public class MapperOfAllSpaces
    {
        public MapperOfAllSpaces()
        { }

        [Key]
        public int Id { get; set; }

        private int[,] board;
        private int rows;
        private int columns;

        public MapperOfAllSpaces(int numRows, int numColumns)
        {
            rows = numRows;
            columns = numColumns;
            board = new int[rows, columns];
        }

     
    }

}
        

    

