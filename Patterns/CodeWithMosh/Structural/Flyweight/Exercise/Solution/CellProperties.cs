using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Flyweight.Exercise.Solution
{
   public  class CellProperties
    {
        public String fontFamily;
        public int fontSize;
        public bool isBold;

        public CellProperties(string fontFamily, int fontSize, bool isBold)
        {
            this.fontFamily = fontFamily;
            this.fontSize = fontSize;
            this.isBold = isBold;
        }
    }
}
