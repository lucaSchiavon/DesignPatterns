using DesignPatterns.Patterns.CodeWithMosh.Command.MakingUndo;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Command.MakingUndo
{
    public class UndoCommand : ICommand
    {
        private readonly DesignPatterns.Patterns.CodeWithMosh.Command.MakingUndo.History history;

        public UndoCommand(DesignPatterns.Patterns.CodeWithMosh.Command.MakingUndo.History history)
        {
            this.history = history;
        }

        public void Execute()
        {
            if (history.Size()>0)
            history.Pop().Unexecute();
        }
    }
}
