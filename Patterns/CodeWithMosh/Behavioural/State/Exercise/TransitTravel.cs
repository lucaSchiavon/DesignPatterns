using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.State.Exercise
{
    class TransitTravel : ITravel
    {
        public object getDirection()
        {
            Console.WriteLine("Calculating Direction (transit)");
            return 3;
        }

        public object getEta()
        {
            Console.WriteLine("Calculating ETA (transit)");
            return 3;
        }
    }
}
