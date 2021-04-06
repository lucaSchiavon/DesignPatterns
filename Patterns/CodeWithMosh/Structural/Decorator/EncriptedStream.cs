using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Decorator
{
    class EncriptedStream:CloudStream
    {
        public override void Write(string data)
        {
          var  encriptedData = Encrypt(data);
            base.Write(encriptedData);
        }

        private string Encrypt(String data)
        {
            return "ret54i9843yt";
        }
    }
}
