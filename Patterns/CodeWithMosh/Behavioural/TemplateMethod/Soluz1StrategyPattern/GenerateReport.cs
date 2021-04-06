using DesignPatterns.Patterns.CodeWithMosh.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.TemplateMethod.Soluz1StrategyPattern
{
    class GenerateReport : ITask
    {
        public void Execute()
        {
            Console.WriteLine("report generato");
        }
    }
}
