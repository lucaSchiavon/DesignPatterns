using DesignPatterns.Patterns.CodeWithMosh.TemplateMethod.Soluz1StrategyPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.TemplateMethod.Soluz2StrategyPattern
{
    public abstract class Task
    {
        private IAuditTrail auditTrail;

        public Task(IAuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }
        //questo è il nostro template:
        public void Execute()
        {
            auditTrail.Record();
            DoExecute();
        }

        protected abstract void DoExecute();
    }
}
