using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.TemplateMethod.Soluz1StrategyPattern
{
    public class AuditTrailOnDB : IAuditTrail
    {
        public void Record()
        {
            Console.WriteLine("Registra sul DB");
        }
    }
}
