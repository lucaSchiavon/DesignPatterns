using DesignPatterns.Patterns.CodeWithMosh.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.TemplateMethod.Soluz1StrategyPattern
{
    class TransferMoney : ITask
    {
        public void Execute()
        {
            Console.WriteLine("trasferiti i soldi");
        }
    }
}
