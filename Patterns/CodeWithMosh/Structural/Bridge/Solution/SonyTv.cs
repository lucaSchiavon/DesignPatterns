using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Bridge.Solution
{
    class SonyTv : Device
    {
        public void SetChannel(int number)
        {
            Console.WriteLine("Sony: set channel $number" + number);
         
        }

        public void TurnOff()
        {
            Console.WriteLine("Sony: TurnOff");
        }

        public void TurnOn()
        {
            Console.WriteLine("Sony: TurnOn");
        }
    }
}
