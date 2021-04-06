using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Adapter
{
    class VividFilter : IFilter
    {
        public void Apply(Image img)
        {
            Console.WriteLine("apply vivid filter");
        }
    }
}
