using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Adapter.Exercise
{
    interface IEmailProvider
    {
        public void Connect(Server server);
    }
}
