using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Chain
{
    class HttpRequest
    {
        public string username;
        public string password;

        public HttpRequest(string password, string username)
        {
            this.password = password;
            this.username = username;
        }
    }
}
