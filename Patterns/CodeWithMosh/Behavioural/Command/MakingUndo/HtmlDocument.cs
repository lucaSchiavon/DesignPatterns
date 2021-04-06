using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Command.MakingUndo
{
    class HtmlDocument
    {
        public string content { get; set; }
        public void MakeBold()
        {
            content = "<b>" + content + "</b>";
        }
    }
}
