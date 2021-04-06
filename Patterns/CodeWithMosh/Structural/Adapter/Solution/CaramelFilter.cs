using DesignPatterns.Patterns.CodeWithMosh.Structural.Adapter.avaFilter;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Adapter.Solution
{
    class CaramelFilter : IFilter
    {
        private Caramel caramel;
        public CaramelFilter(Caramel caramel)
        {
            this.caramel = caramel;
        }

        public void Apply(Image img)
        {
            caramel.init();
            caramel.Render(img);
        }
    }
}
