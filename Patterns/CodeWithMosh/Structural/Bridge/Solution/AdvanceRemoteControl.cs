using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Bridge.Solution
{
    public  class AdvanceRemoteControl : RemoteControl
    {
       
        public AdvanceRemoteControl(Device device)
            :base(device)
        {
            this.device = device;
        }

        public void SetChannel(int number)
        {
            device.SetChannel(number);
        }
    }
}
