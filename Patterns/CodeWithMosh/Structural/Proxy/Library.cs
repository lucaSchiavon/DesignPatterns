using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Proxy
{
    class Library
    {
        private Dictionary<String, Ebook> ebooks = new Dictionary<string, Ebook>();
        public void add(Ebook ebook)
        {
            ebooks.Add(ebook.getFileName(), ebook);
        }

        public void OpenEbook(string fileName)
        {
            ebooks[fileName].Show();
        }
    }
}
