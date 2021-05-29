using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Behavioural.State.ClockExample
{
    public class NormalDisplayState : ClockState
    {
        public NormalDisplayState(Clock clock)
            :base(clock)
        {

        }
        public override void ChangeButton()
        {
            Console.WriteLine("Light on");
        }

        public override void ModeButton()
        {
            Clock.SetState(new UpdateHrState(Clock));
        }
    }
}
