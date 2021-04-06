using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Visitor
{
    class ExtractTextOperation : IOperation
    {
        public void Apply(HeadingNode headingNode)
        {
            Console.WriteLine("extract test heading");
        }

        public void Apply(AnchorNode anchorNode)
        {
            Console.WriteLine("extract test ancor");
        }
    }
}
