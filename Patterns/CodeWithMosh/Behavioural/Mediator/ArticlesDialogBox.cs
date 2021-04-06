using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Mediator
{
    //concrete mediator
    class ArticlesDialogBox : DialogBox
    {
        private ListBox articlesListBox;
        private Button saveButton;
        private TextBox titleTextBox;

        public ArticlesDialogBox()
        {
            this.articlesListBox = new ListBox(this);
            this.saveButton = new Button(this);
            this.titleTextBox = new TextBox(this);
        }

        public void SimulateSelection()
        {
            articlesListBox.Selection="Article1";
            Console.WriteLine("Textbox: " + titleTextBox.Content);
            Console.WriteLine("button: " + saveButton.IsEnabled);
        }

        public override void Changed(UIControl uIControl)
        {
            if (uIControl == articlesListBox)
                articleSelected();
            else if (uIControl == titleTextBox)
                titleChanged();
        }

        private void articleSelected()
        {
            titleTextBox.Content = articlesListBox.Selection;
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
