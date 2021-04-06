using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Mediator
{
    //concrete collegue
    class Button : UIControl
    {
        public Button(DialogBox owner)
          : base(owner)
        {

        }
        private bool _isEnabled;

        public bool IsEnabled
        {
            get { return _isEnabled; }
            set { 
                _isEnabled = value;
                Owner.Changed(this);
            }
        }

    }
}
