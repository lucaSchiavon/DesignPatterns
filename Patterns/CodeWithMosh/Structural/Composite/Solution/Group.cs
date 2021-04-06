using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Composite.Solution
{
    class Group : IComponent
    {
        private List<IComponent> components = new List<IComponent>();

        public void Add(IComponent component)
        {
            components.Add(component);
        }


        public void Render()
        {
            Console.WriteLine("render Group");
            components.ForEach(x => x.Render());
        }

        public void Move()
        {
            components.ForEach(x => x.Move());
        }
    }
}
