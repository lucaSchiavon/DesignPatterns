using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Bridge.Solution
{
   public interface Device
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int number);

    }
}
