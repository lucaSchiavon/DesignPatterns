using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.State.Exercise
{
    class BiciclingTravel : ITravel
    {
        public object getDirection()
        {
            Console.WriteLine("Calculating Direction (bicycling)");
            return 2;
        }

        public object getEta()
        {
            Console.WriteLine("Calculating ETA (bicycling)");
            return 2;
        }
    }
}
