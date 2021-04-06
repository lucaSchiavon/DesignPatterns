using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Composite.Exercise
{
    class Pompiere : RisorsaNumerator, IRisorsa
    {
       

        public void Schiera()
        {
            numerazione++;
            Console.WriteLine(numerazione + " - Schiera pompiere");
        }

      
    }
}
