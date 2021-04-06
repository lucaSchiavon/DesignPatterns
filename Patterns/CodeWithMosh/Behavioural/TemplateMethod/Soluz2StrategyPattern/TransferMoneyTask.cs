using DesignPatterns.Patterns.CodeWithMosh.TemplateMethod.Soluz1StrategyPattern;
using System;
using System.Collections.Generic;
using System.Text;
using Sol1 = DesignPatterns.Patterns.CodeWithMosh.TemplateMethod.Soluz1StrategyPattern;

namespace DesignPatterns.Patterns.CodeWithMosh.TemplateMethod.Soluz2StrategyPattern
{
    public class TransferMoney : Task
    {
        //private  IAuditTrail _auditTrail { get; }
        public TransferMoney(IAuditTrail auditTrail)
            :base(auditTrail)
        {
           // _auditTrail = auditTrail;
        }



        protected override void DoExecute()
        {
            Console.WriteLine("Transfer money");
            //_auditTrail.Record();
        }
    }
}
