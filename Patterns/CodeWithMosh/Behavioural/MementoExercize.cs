using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Exercize
{
    public class DocumentState
    {
        private List<string> _record { get; }
        //private string _fontName { get; }
        //private string _fontSize { get; }
        public DocumentState(List<string> record)
        {
            _record = record;
            //_fontName = fontName;
            //_fontSize = fontSize;
        }

        public List<string> GetContent()
        {
            return _record;
        }
    }

    public class Document
    {
        private List<string> _record;
        private String _content;
        private String _fontName;
        private int _fontSize;

        public List<String> GetRecord()
        {

            return _record;
        }

        public void SetRecord(List<String> record)
        {
            this._record = record;
        }

        public DocumentState CreateState()
        {
            return new DocumentState(_record);
        }

        public void Restore(DocumentState state)
        {
            _record = state.GetContent();
        }

        public String GetContent()
        {
            
            return _content;
        }

        public void SetContent(String content)
        {
            this._content = content;
        }

       
        public String GetFontName()
        {
            return _fontName;
        }

        public void SetFontName(String fontName)
        {
            this._fontName = fontName;
        }

        public int GetFontSize()
        {
            return _fontSize;
        }

        public void SetFontSize(int fontSize)
        {
            this._fontSize = fontSize;
        }


        public override String ToString()
        {
            return "Document{" +
                    "content='" + _content + '\'' +
                    ", fontName='" + _fontName + '\'' +
                    ", fontSize=" + _fontSize +
                    '}';
        }
    }

        public class History
        {
            public readonly List<DocumentState>  states = new List<DocumentState>();

        public void Push(DocumentState state)
        {
            states.Add(state);
        }
        public DocumentState Pop()
        {
            int LastStateIndex = states.Count - 1;
            var LastDocumentState = states[LastStateIndex];
            states.RemoveAt(LastStateIndex);
            return LastDocumentState;
        }

        }
}
