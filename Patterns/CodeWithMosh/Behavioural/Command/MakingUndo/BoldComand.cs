using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Command.MakingUndo
{
    class BoldComand : IUndoableCommand
    {
        private string prevContent;
        //private HtmlDocument document;
        private readonly HtmlDocument htmlDocument;
        private readonly History history;

        public BoldComand(HtmlDocument htmlDocument, History history)
        {
            this.htmlDocument = htmlDocument;
            this.history = history;
        }

        public void Execute()
        {
            //memorizza nel precedente stato il contenuto non grassetto
            prevContent = htmlDocument.content;
            //applica il contenuto in grassetto all'oggetto corrente
            htmlDocument.MakeBold();
            //memorizza il contenuto in grassetto nello storico
            history.push(this);

        }

        public void Unexecute()
        {
            //riporta a non grassetto il contenuto corrente che è grassettato
            htmlDocument.content = prevContent;
        }
    }
}
