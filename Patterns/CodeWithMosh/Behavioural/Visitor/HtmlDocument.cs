using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Visitor
{
    class HtmlDocument
    {
        private List<IHtmlNode> nodes = new List<IHtmlNode>();

        public void add(IHtmlNode htmlNode)
        {
            nodes.Add(htmlNode);
        }

        public void Execute(IOperation operation)
        {
            foreach (IHtmlNode htmlNode in nodes)
            {
                htmlNode.Execute(operation);
            }
        }
    }
}
