using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Iterator
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Current();
        void Next();

    }
}
