using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Mediator
{
    //Collegue
    class UIControl
    {
        protected DialogBox Owner;

        public UIControl(DialogBox owner)
        {
            Owner = owner;
        }
    }
}
