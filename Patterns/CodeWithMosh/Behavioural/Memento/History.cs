using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Behavioural.Memento
{
    public class History
    {
        private readonly List<EditorState> _states = new List<EditorState>();

        public void Push(EditorState state)
        {
            _states.Add(state);
        }
        public EditorState Pop()
        {
            int lastIndex = _states.Count - 1;
            var LastState = _states[lastIndex];
            _states.RemoveAt(lastIndex);

            return LastState;
        }

    }
}
