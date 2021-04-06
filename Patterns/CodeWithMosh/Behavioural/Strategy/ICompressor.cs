using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Strategy
{
    public interface ICompressor
    {
        void Compress(string FileName);
    }
}
