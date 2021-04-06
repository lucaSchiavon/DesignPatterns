using System;
using System.Collections.Generic;
using System.Text;


namespace DesignPatterns.Patterns.CodeWithMosh.Observer.Passing_Value
{
    class Chart : IObserver
    {
      
        public void Update(int value)
        {
            Console.WriteLine("Chart got updated " + value);
        }
    }
}
