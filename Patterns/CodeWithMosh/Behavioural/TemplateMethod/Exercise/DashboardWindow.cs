using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.TemplateMethod.Exercise
{
    class DashboardWindow : WindowTask
    {
        
        protected override void DoExecuteAfter()
        {
            Console.WriteLine("operazioni dopo chiudura fiestra dashboard");
        }

        protected override void DoExecuteBefore()
        {
            Console.WriteLine("operazioni prima chiudura fiestra dashboard");
        }
    }
}
