using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Visitor
{
    interface IHtmlNode
    {
        void Execute(IOperation operation);
    }
}
