using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Behavioural.Memento
{
    public class EditorState
    {
        public Button Button { get; }
      
        public EditorState(Button button)
        {
            this.Button = button;
          
        }

    
    }
}
