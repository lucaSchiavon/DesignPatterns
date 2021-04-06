using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Bridge.Solution2
{
    public  class AdvanceRemoteControl : RemoteControl
    {
       
        public AdvanceRemoteControl(Solution2.Device device)
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
