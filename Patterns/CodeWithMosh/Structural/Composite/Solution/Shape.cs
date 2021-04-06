using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Composite.Solution
{
    class Shape : IComponent
    {
        public void Move()
        {
            Console.WriteLine("move shape");
        }

        public void Render()
        {
            Console.WriteLine("render shape");
        }
    }
}
