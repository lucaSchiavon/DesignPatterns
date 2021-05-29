using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Behavioural.State.ClockExample
{
    public class Clock
    {
        public int Hr;
        public int Min;
        private ClockState ClockState;
        public Clock()
        {
            ClockState = new NormalDisplayState(this);
        }

        public void SetState(ClockState cs)
        {
            ClockState = cs;
        }

        public void ModeButton()
        {
            ClockState.ModeButton();
        }
        public void ChangeButton()
        {
            ClockState.ChangeButton();
        }
    }
}
