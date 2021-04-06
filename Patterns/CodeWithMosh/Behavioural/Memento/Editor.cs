using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Behavioural.Memento
{
    public class Editor
    {
        //ritorna lo stato attuale
        public Button Button { get; set; }


        public EditorState CreateState()
        {
            return new EditorState(Button);
        }

        //ritorna lo stato precedente
        public void Restore(EditorState state)
        {
            Button = state.Button;
        }

      

    }
}
