using DesignPatterns.Patterns.CodeWithMosh.Behavioural.Command.CompositeCommand;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Behavioural.Command.CompositeCommand
{
    class CompositeComand : ICommand
    {
        private List<ICommand> commands = new List<ICommand>();

        public void Add(ICommand comand)
        {
            commands.Add(comand);
        }
        public void Execute()
        {
            foreach (ICommand cmd in commands)
            {
                cmd.Execute();
            }
        }
    }
}
