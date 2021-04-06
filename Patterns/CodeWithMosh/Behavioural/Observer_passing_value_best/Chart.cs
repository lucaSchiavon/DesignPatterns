using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Observer
{
    //Concrete observer
    class Chart : IObserver
    {
        public DataSource DataSource { get; }
        public Chart(DataSource dataSource)
        {
            DataSource = dataSource;
        }
        public void Update()
        {
            Console.WriteLine("Chart got updated " + DataSource.Value);
        }
    }
}
