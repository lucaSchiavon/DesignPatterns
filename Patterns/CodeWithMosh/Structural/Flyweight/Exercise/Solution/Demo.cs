﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Flyweight.Exercise.Solution
{
    class Demo
    {
        public static void show()
        {
            var sheet = new SpreadSheet(new CellPropertiesFactory());
            sheet.setContent(0, 0, "Hello");
            sheet.setContent(1, 0, "World");
            sheet.setFontFamily(0, 0, "Arial");
            sheet.render();
        }
    }
}
