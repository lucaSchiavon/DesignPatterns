using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Strategy
{
    class JpgCompressor : ICompressor
    {
        public void Compress(string FileName)
        {
            Console.WriteLine("compress jpg img");
        }
    }
}
