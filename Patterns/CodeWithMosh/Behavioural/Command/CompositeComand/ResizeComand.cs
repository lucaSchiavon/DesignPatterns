using DesignPatterns.Patterns.CodeWithMosh.Behavioural.Command.CompositeCommand;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Behavioural.Command.CompositeCommand
{
    class ResizeComand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("resize");
        }
    }
}
