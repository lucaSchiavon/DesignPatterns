using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Flyweight.Exercise
{
    public class Cell
    {
        private readonly int row;
        private readonly int column;
        private String content;
        private String fontFamily;
        private int fontSize;
        private bool isBold;

        public Cell(int row, int column)
        {
            this.row = row;
            this.column = column;
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
            return fontFamily;
        }

        public void SetFontFamily(String fontFamily)
        {
            this.fontFamily = fontFamily;
        }

        public int GetFontSize()
        {
            return fontSize;
        }

        public void SetFontSize(int fontSize)
        {
            this.fontSize = fontSize;
        }

        public bool IsBold()
        {
            return isBold;
        }

        public void SetBold(bool bold)
        {
            isBold = bold;
        }

        public void Render()
        {
            Console.WriteLine(string.Format( "({0}, {1}): {2} [{2}]", row, column, content, fontFamily));
        }
    }
}
