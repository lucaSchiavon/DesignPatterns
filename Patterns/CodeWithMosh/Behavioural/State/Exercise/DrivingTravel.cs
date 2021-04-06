using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.State.Exercise
{
    class DrivingTravel : ITravel
    {
        public object getDirection()
        {
            Console.WriteLine("Calculating Direction (driving)");
            return 1;
        }

        public object getEta()
        {
            Console.WriteLine("Calculating ETA (driving)");
            return 1;
        }
    }
}
