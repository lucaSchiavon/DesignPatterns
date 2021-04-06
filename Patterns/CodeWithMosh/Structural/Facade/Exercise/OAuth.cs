using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Facade.Exercise
{
    class OAuth
    {
        public String requestToken(String appKey, String appSecret)
        {
            Console.WriteLine("Get a request token");
            return "requestToken";
        }

        public String getAccessToken(String requestToken)
        {
            Console.WriteLine("Get an access token");
            return "accessToken";
        }
    }
}
