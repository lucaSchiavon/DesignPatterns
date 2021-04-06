using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.State
{
    public class Canvas : ITool
    {
        private ITool _tool { get; }
        public Canvas(ITool tool)
        {
            _tool = tool;
        }

        

        public void mouseDown()
        {
            _tool.mouseDown();
        }
        public void MouseUp()
        {
            _tool.MouseUp();
        }
    }
}
