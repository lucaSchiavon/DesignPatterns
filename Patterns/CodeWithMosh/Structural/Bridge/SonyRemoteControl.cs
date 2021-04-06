using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Bridge
{
    class SonyRemoteControl : RemoteControl
    {
        public override void TurnOff()
        {
            Console.WriteLine("Sony: TurnOff");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Sony: TurnOn");
        }
    }
}
