using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Flyweight.Exercise.Solution
{
    public class Cell
    {

        private readonly int row;
        private readonly int column;
        private CellProperties cellProperties;
        private String content;
        //private String fontFamily;
        //private int fontSize;
        //private bool isBold;


        public Cell(int row, int column, CellProperties cellProperties)
        {
            this.row = row;
            this.column = column;
            this.cellProperties = cellProperties;
        }

        public String GetContent()
        {
            return content;
        }

        public void SetContent(String content)
        {
            this.content = content;
        }

        public String GetFontFamily()
        {
            //return fontFamily;
            return cellProperties.fontFamily;
        }

        public void SetFontFamily(String fontFamily)
        {
            this.cellProperties.fontFamily = fontFamily;
        }

        public int GetFontSize()
        {
            return cellProperties.fontSize;
        }

        public void SetFontSize(int fontSize)
        {
            this.cellProperties.fontSize = fontSize;
        }

        public bool IsBold()
        {
            return cellProperties.isBold;
        }

        public void SetBold(bool bold)
        {
            cellProperties.isBold = bold;
        }

        public void Render()
        {
            Console.WriteLine(string.Format("({0}, {1}): {2} [{2}{3}{4}]", row, column, content, cellProperties.fontFamily, cellProperties.fontSize,cellProperties.isBold));
        }
    }
}
