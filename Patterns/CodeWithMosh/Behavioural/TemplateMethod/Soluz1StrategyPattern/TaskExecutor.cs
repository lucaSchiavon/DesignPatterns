using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.TemplateMethod.Soluz1StrategyPattern
{
    public class TaskExecutor
    {
        private ITask _task { get; }
        private IAuditTrail _auditTrail { get; }

        public TaskExecutor(ITask task, IAuditTrail auditTrail)
        {
            _task = task;
            _auditTrail = auditTrail;
        }

        //questo è il nostro template
        public void Execute()
        {
            _auditTrail.Record();
            _task.Execute();
        }
      
    }
}
