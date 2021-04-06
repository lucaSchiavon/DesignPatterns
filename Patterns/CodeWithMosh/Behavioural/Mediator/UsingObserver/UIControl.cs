using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Mediator.UsingObserver
{
    abstract class UIControl
    {
        private List<IObserver> observers = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }
        //public void RemoveObserver(IObserver observer)
        //{
        //    observers.Remove(observer);
        //}

        protected void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }

    }
}
