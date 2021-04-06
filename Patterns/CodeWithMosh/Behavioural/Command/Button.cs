using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Command
{
   public class Button
    {
        public string Label { get; set; }
        public ICommand _command { get; }

        public Button(ICommand command)
        {
            _command = command;
        }
        public void click()
        {
            _command.Execute();
        }
    }
}
