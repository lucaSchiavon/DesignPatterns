using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.TemplateMethod.Exercise
{
    public abstract class WindowTask
    {
       
        public void Close()
        {
            DoExecuteBefore();
            Console.WriteLine("chiude la finestra");
            DoExecuteAfter();

        }

        protected abstract void DoExecuteBefore();
        protected abstract void DoExecuteAfter();
    }
}
