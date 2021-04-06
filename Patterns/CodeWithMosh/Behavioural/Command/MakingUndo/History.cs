using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Command.MakingUndo
{
    public class History
    {
        
        private List<IUndoableCommand> undoableCommands = new List<IUndoableCommand>();
        private int index;
        public void push(IUndoableCommand undoableCommand)
        {
            undoableCommands.Add(undoableCommand);
        }
        public IUndoableCommand Pop()
        {
            var LastIndex = undoableCommands.Count - 1;
            var LastCommand = undoableCommands[LastIndex];
            undoableCommands.RemoveAt(LastIndex);

            return LastCommand;
        }

        public int Size()
        {
            return undoableCommands.Count;
        }

    }
}
