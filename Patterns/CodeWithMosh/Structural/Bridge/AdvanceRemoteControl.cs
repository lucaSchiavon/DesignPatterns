using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Bridge
{
    public abstract class AdvanceRemoteControl:RemoteControl
    {
        public abstract void SetChannel(int Number);
    }
}
