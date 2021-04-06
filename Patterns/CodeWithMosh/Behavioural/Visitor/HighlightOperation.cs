using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Visitor
{
    class HighlightOperation : IOperation
    {
        public void Apply(HeadingNode headingNode)
        {
            Console.WriteLine("highlight heading");
        }

        public void Apply(AnchorNode anchorNode)
        {
            Console.WriteLine("highlight ancor");
        }
    }
}
