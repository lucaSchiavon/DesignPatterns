using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Behavioural.State.ClockExample
{
    public abstract class ClockState
    {
        protected Clock Clock;

        protected ClockState(Clock clock)
        {
            Clock = clock;
        }

        public abstract void ModeButton();
        public abstract void ChangeButton();

    }
}
