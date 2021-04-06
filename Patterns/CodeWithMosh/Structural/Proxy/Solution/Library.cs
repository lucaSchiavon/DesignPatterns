using DesignPatterns.Patterns.CodeWithMosh.Structural.Proxy.solution;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Proxy.Solution
{
    class Library
    {
        private Dictionary<String, IEbook> ebooks = new Dictionary<string, IEbook>();
        public void add(IEbook ebook)
        {
            ebooks.Add(ebook.getFileName(), ebook);
        }

        public void OpenEbook(string fileName)
        {
            ebooks[fileName].Show();
        }
    }
}
