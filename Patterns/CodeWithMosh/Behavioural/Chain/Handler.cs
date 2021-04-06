using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Chain
{
    abstract class Handler
    {
        private Handler next;

        public Handler(Handler next)
        {
            this.next = next;
        }
        public void Handle(HttpRequest request)
        {
           if(DoHandle(request))
           //stoppa il processo qui
            return;

            //chiama il prossimo processo nella catena
            if(next!=null)
            next.Handle(request);
        }
        protected abstract bool DoHandle(HttpRequest request);
    }
}
