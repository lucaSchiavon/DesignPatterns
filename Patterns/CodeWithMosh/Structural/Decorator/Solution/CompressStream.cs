using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Decorator.Solution
{
    class CompressStream:IStream
    {
        private IStream stream;
        public CompressStream(IStream stream)
        {
            this.stream = stream;
        }

        public void Write(string data)
        {
            var compressedData = Compress(data);
            stream.Write(compressedData);
        }

      
        private string Compress(String data)
        {
            return data.Substring(0,3);
        }
    }
}
