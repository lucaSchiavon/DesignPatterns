using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Mediator.UsingObserver
{
    class Button : UIControl
    {
      
        private bool _isEnabled;

        public bool IsEnabled
        {
            get { return _isEnabled; }
            set { 
                _isEnabled = value;
                NotifyObservers();
            }
        }

    }
}
