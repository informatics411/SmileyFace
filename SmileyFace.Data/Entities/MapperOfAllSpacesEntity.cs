
using System;
using System.ComponentModel.DataAnnotations;
namespace SmileyFace.Data.Entities

{
    public class MapperOfAllSpacesEntity
    {
        public MapperOfAllSpacesEntity()
        { }

        [Key]
        public int Id { get; set; }

        private int[,] board;
        private int rows;
        private int columns;

        public MapperOfAllSpacesEntity(int numRows, int numColumns)
        {
            rows = numRows;
            columns = numColumns;
            board = new int[rows, columns];
        }

     
    }

}
        

    

