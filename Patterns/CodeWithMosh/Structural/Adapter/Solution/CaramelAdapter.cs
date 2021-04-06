using DesignPatterns.Patterns.CodeWithMosh.Structural.Adapter.avaFilter;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Adapter.Solution
{
    class CaramelAdapter : Caramel, IFilter
    {
        public void Apply(Image img)
        {
            init();
            Render(img);
        }
    }
}
