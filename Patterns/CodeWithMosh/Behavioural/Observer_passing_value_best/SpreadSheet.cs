using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Observer
{
    //concrete observer
    class SpreadSheet : IObserver
    {
        public DataSource DataSource { get; }
        public SpreadSheet(DataSource dataSource)
        {
            DataSource = dataSource;
        }

       

        public void Update()
        {
            Console.WriteLine("spreadsheet get notified " + DataSource.Value);
        }
    }
}
