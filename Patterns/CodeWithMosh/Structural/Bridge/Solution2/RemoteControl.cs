using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Bridge.Solution2
{
    public  class RemoteControl
    {
        protected Device device;

        public RemoteControl(Device device)
        {
            this.device = device;
        }

        public void TurnOn()
        {
            device.TurnOn();
        }

        public  void TurnOff()
        {
            device.TurnOff();
        }
    }
}
