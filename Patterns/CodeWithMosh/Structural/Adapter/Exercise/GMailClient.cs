using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Adapter.Exercise
{
    class GMailClient
    {
        public void ConnectTo(string Ip)
        {
            Console.WriteLine("Connect to GmailClient " + Ip);
        }
    }
}
