﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Proxy.solution
{
    class RealEbook : IEbook
    {
        private string fileName;

        public RealEbook(string fileName)
        {
            this.fileName = fileName;
            Load();
        }

        private void Load()
        {
            Console.WriteLine("Loading the ebook " + fileName);
        }

        public void Show()
        {
            Console.WriteLine("Showing the ebook " + fileName);
        }

        public string getFileName()
        {
            return fileName;
        }
    }
}
