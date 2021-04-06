using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Visitor
{
    class HeadingNode : IHtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }

     
    }
}
