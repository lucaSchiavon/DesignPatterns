using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Observer.Passing_Value
{
    public interface IObserver
    {
        void Update(int value);
    }
}
