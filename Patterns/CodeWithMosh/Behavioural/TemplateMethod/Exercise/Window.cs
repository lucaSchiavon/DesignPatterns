using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.TemplateMethod.Exercise
{
    public interface IWindow
    {
        void close();
    }

    public class Window : IWindow
    {
        public void close()
        {
            //TODO: custom windows may need to execute some code before the window
            // is closed.

            Console.WriteLine("Removing the window from the screen");

            //TODO: custom windows may need to execute some code after the window
            // is closed.
        }
    }
}
