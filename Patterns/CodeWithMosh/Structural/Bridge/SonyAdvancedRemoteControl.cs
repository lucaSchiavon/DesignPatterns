using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Bridge
{
    class SonyAdvancedRemoteControl : AdvanceRemoteControl
    {
        public override void SetChannel(int Number)
        {
            Console.WriteLine("Sony: TurnOn setchannel" + Number);
        }

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
