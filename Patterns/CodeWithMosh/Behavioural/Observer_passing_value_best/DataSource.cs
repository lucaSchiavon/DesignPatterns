using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Observer
{

    //Concrete subject
    class DataSource:Subject
    {
        private int _value;

        public int Value
        {
            get { return _value; }
            set { 
                _value = value;
                NotifyObservers();
            }
        }

    }
}
