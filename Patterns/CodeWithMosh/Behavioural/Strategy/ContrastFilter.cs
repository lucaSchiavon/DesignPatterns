using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Strategy
{
    public class ContrastFilter : IFilter
    {
        public void Apply(string FileName)
        {
            Console.WriteLine("applica filtro contrasto");
        }
    }
}
