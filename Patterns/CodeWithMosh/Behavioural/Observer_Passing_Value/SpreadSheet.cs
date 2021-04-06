using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Observer.Passing_Value
{
    class SpreadSheet : IObserver
    {
      
        public void Update(int value)
        {
            Console.WriteLine("spreadsheet get notified " + value);
        }
    }
}
