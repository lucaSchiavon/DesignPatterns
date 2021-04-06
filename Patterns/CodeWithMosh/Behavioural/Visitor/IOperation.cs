using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Visitor
{
    interface IOperation
    {
        void Apply(HeadingNode headingNode);
        void Apply(AnchorNode anchorNode);
    }
}
