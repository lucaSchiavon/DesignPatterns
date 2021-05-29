using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Behavioural.State.ClockExample
{
    public class UpdateHrState : ClockState
    {
        public UpdateHrState(Clock clock)
            :base(clock)
        {

        }
        public override void ChangeButton()
        {
            Clock.Hr++;
            if (Clock.Hr == 24)
                Clock.Hr = 0;
        }

        public override void ModeButton()
        {
            Clock.SetState(new UpdateMinState(Clock));
        }
    }
}
