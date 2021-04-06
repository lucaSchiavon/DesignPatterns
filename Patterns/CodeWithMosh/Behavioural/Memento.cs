using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh
{

    //rappresenta un editor state con il suo contenuto
    public class EditorState
    {
        private readonly string _content;
        public EditorState(string content)
        {
            _content = content;
        }

        public string GetContent()
        {
            return _content;
        }
    }

    //imposta il contenuto, ritorna il contenuto, crea uno stato, ripristina uno stato
    public class Editor
    {
        private string _content;

        public string GetContent()
        {
            return _content;
        }

        public EditorState CreateState()
        {
            return new EditorState(_content);
        }

        public void Restore(EditorState state)
        {
            _content = state.GetContent();
        }

        public void SetContent(string content)
        {
            _content = content;
        }

    }

    //rappresenta la storia degli stati
    //è possibile aggiungere nuovi stati alla pila LIFO
        public class History
        {
            private readonly List<EditorState> _states = new List<EditorState>();

        public void Push(EditorState state)
        {
            _states.Add(state);
        }
        public EditorState Pop()
        {
            int lastIndex = _states.Count- 1;
            var LastState = _states[lastIndex];
            _states.RemoveAt(lastIndex);

            return LastState;
        }

        }
}
