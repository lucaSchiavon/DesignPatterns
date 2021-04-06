using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Decorator.Solution
{
    class EncriptedStream:IStream
    {
        private IStream stream;

        public EncriptedStream(IStream stream)
        {
            this.stream = stream;
        }

        public void Write(string data)
        {
            var encriptedData = Encrypt(data);
            stream.Write(encriptedData);
        }

        
        private string Encrypt(String data)
        {
            return "ret54i9843yt";
        }
    }
}
