using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Mediator
{
    //Mediator
    abstract class DialogBox
    {
        public abstract void Changed(UIControl uIControl);
    }
}
