using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Iterator
{
    public class BrowseHistory
    {
       // private List<String> urls = new List<String>();
        private String[] urls=new string[0];

        public IIterator<string> CreateIterator()
        {

            //return new ListIterator(history:this);
            return new ArrayIterator(history: this);
        }
        public void Push(string url)
        {
            Array.Resize(ref urls, urls.Length+1);
            urls[urls.Length - 1] = url;

            //urls.Add(url);
        }
        public string Pop()
        {
           

            var LastIndex = urls.Length - 1;
            var LastUrl = urls[LastIndex];
            Array.Clear(urls, 1, urls.Length - 1);
            //Array.Resize(ref urls, 1);
           

            //var LastIndex = urls.Count - 1;
            //var LastUrl = urls[LastIndex];
            //urls.RemoveAt(LastIndex);
            return LastUrl;
        }
        //public class ListIterator : IIterator<string>
        //{
        //    private BrowseHistory _history { get; }
        //    private int _index;
        //    public ListIterator(BrowseHistory history)
        //    {
        //        _history = history;
        //    }



        //    public string Current()
        //    {
        //        return _history.urls[_index];
        //    }

        //    public bool HasNext()
        //    {
        //        return (_index < _history.urls.Count);
        //    }

        //    public void Next()
        //    {
        //        _index++;
        //    }
        //}

        public class ArrayIterator : IIterator<string>
        {
            private BrowseHistory _history { get; }
            private int _index;
            public ArrayIterator(BrowseHistory history)
            {
                _history = history;
            }



            public string Current()
            {
                return _history.urls[_index];
            }

            public bool HasNext()
            {
                return (_index < _history.urls.Length);
                //return (_index < _history.urls.Count);
            }

            public void Next()
            {
                _index++;
            }
        }

    }




}
