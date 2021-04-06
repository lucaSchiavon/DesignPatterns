using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Flyweight.Exercise.Solution
{
    public class SpreadSheet
    {
        private CellPropertiesFactory CellPropertiesFactory;

     
        private  const int MAX_ROWS = 3;
        private  const int MAX_COLS = 3;

        // In a real app, these values should not be hardcoded here.
        // They should be read from a configuration file.
        private readonly String fontFamily = "Times New Roman";
        private readonly int fontSize = 12;
        private readonly bool isBold = false;

         private Cell[,] cells = new Cell[MAX_ROWS,MAX_COLS];

        public SpreadSheet(CellPropertiesFactory cellPropertiesFactory)
        {
            CellPropertiesFactory = cellPropertiesFactory;
            generateCells();
        }


        public void setContent(int row, int col, String content)
        {
            ensureCellExists(row, col);

            cells[row,col].SetContent(content);
        }

        public void setFontFamily(int row, int col, String fontFamily)
        {
            ensureCellExists(row, col);

            var cell = cells[row,col];
            cells[row,col].SetFontFamily(fontFamily);
        }

        private void ensureCellExists(int row, int col)
        {
            if (row < 0 || row >= MAX_ROWS)
                throw new InvalidOperationException();

            if (col < 0 || col >= MAX_COLS)
                throw new InvalidOperationException();
        }

        private void generateCells()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                {
                    var cell = new Cell(row, col, CellPropertiesFactory.GetCellProperties("Times New Roman|12|false"));
                    //cell.SetFontFamily(fontFamily);
                    cells[row,col] = cell;
                }
        }

        public void render()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                    cells[row,col].Render();
        }
    }

}
