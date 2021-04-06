using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Composite
{
    class Group
    {
        List<Object> objects = new List<Object>();
        public void Add(Object shape)
        {
            objects.Add(shape);
        }

        public void Render()
        {
            foreach (Object obj in objects)
            {
                if (typeof(Shape).IsInstanceOfType(obj))
                    ((Shape)obj).Render();
                else
                    ((Group)obj).Render();
            }
        }
    }
}
