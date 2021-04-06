using DesignPatterns.Patterns.CodeWithMosh.Structural.Proxy.solution;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Proxy.Solution
{
    class EbookProxy : IEbook
    {
        private string fileName;
        private RealEbook ebook;

        public EbookProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public string getFileName()
        {
            return fileName;
        }

        public void Show()
        {
            if (ebook == null)
                ebook = new RealEbook(fileName);
            ebook.Show();
        }
    }
}
