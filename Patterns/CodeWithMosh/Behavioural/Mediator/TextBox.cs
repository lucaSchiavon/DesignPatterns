using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Mediator
{
    //concrete collegue
    class TextBox :UIControl
    {
        public TextBox(DialogBox owner)
           : base(owner)
        {

        }
        private string _content;

        public string Content
        {
            get { return _content; }
            set {
                _content = value;
                Owner.Changed(this);
            }
        }


    }
}
