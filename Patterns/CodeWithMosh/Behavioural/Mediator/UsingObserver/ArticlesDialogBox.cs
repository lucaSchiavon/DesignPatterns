using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Mediator.UsingObserver
{
    class ArticlesDialogBox 
    {
       // private ListBox articlesListBox;
        private Button saveButton=new Button();
        private TextBox titleTextBox=new TextBox();

        public ArticlesDialogBox()
        {
            //this.articlesListBox = new ListBox(this);
           // titleTextBox.Attach(() => { titleChanged(); });
            this.titleTextBox = new TextBox();
        }

        public void SimulateSelection()
        {
          
            Console.WriteLine("Textbox: " + titleTextBox.Content);
            Console.WriteLine("button: " + saveButton.IsEnabled);
        }

       

        private void articleSelected()
        {
            
            saveButton.IsEnabled = true;
        }
        private void titleChanged()
        {
            var content = titleTextBox.Content;
            bool isEmpty = (string.IsNullOrEmpty(content));
            saveButton.IsEnabled = !isEmpty;
        }

    }
}
