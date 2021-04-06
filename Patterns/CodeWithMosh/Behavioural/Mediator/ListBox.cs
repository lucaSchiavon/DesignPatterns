using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Mediator
{
    //concrete collegue
    class ListBox : UIControl
    {
       public ListBox(DialogBox owner)
           : base(owner)
        {

        }
        private string _selection;

        public string Selection
        {
            get { return _selection; }
            set 
            { 
                _selection = value;
                Owner.Changed(this);
            }
        }

    }
}
