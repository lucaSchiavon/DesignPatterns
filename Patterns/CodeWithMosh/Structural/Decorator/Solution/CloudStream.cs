using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Decorator.Solution
{
    class CloudStream : IStream

    {
       
        public void Write(string data)
        {
            Console.WriteLine("Store" + data);
        }
    }
}
