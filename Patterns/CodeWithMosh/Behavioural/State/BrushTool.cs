using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.State
{
    class BrushTool : ITool
    {
        public void mouseDown()
        {
            Console.WriteLine("brush icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a line");
        }
    }
}
