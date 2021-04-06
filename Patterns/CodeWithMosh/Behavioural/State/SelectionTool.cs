using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.State
{
    class SelectionTool : ITool
    {
        public void mouseDown()
        {
            Console.WriteLine("selection icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a selection");
        }
    }
}
