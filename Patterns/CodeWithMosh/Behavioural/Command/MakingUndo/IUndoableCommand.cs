using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Command.MakingUndo
{
    public interface IUndoableCommand:ICommand
    {
        void Unexecute();
    }
}
