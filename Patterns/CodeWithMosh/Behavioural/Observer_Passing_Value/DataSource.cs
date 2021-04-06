using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Observer.Passing_Value
{
    class DataSource:Subject
    {
        private int _value;

        public int Value
        {
            get { return _value; }
            set { 
                _value = value;
                NotifyObservers(Value);
            }
        }

    }
}
