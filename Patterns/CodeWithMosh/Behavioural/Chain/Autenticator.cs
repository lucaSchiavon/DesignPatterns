using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Chain
{
    class Autenticator:Handler
    {
        public Autenticator(Handler next)
            :base(next)
        {

        }

        protected override bool DoHandle(HttpRequest request)
        {
            var isValid = (request.username == "admin" && request.password == "1234");
            return !isValid;
        }
    }
}
