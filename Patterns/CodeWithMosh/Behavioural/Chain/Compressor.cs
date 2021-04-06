using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Chain
{
    class Compressor:Handler
    {
        public Compressor(Handler next)
            :base(next)
        {

        }

        protected override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Compress");
            return true;
        }
    }
}
