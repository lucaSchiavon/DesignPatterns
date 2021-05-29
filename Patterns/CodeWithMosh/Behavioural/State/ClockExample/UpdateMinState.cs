using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Behavioural.State.ClockExample
{
    public class UpdateMinState : ClockState
    {
        public UpdateMinState(Clock clock)
            :base(clock)
        {

        }
        public override void ChangeButton()
        {
            Clock.Min++;
            if (Clock.Min == 60)
                Clock.Min = 0;
        }

        public override void ModeButton()
        {
            Clock.SetState(new NormalDisplayState(Clock));
        }
    }
}
