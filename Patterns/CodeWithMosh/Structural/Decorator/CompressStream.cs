using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Decorator
{
    class CompressStream:CloudStream
    {
        public override void Write(string data)
        {
          var  compressedData = Compress(data);
            base.Write(compressedData);
        }

        private string Compress(String data)
        {
            return data.Substring(0,3);
        }
    }
}
