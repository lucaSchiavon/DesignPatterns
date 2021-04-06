using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Chain
{
    class WebServer
    {
        private Handler handler;

        public WebServer(Handler handler)
        {
            this.handler = handler;
        }

        public void Handle(HttpRequest request)
        {
            handler.Handle(request);
        //Authentication
        //Logging
        //Compression
        }
    }
}
