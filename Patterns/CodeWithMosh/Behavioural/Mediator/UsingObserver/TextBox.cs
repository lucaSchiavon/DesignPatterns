using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Mediator.UsingObserver
{
    class TextBox:UIControl
    {
       
        private string _content;

        public string Content
        {
            get { return _content; }
            set {
                _content = value;
                NotifyObservers();
            }
        }


    }
}
