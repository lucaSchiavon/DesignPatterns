using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Observer.Passing_Value
{
    //Observable
    class Subject
    {
        private List<IObserver> observers = new List<IObserver>();
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(int value)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(value);
            }
        }

    }
}
