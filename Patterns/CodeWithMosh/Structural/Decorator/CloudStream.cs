using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Decorator
{
    class CloudStream
    {
        //legge e scrive dati sul cloud
        public virtual void Write(String data)
        {
            Console.WriteLine("Store" + data);
        }
    }
}
