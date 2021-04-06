using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Iterator.Exercise
{
    public class ProductCollection
    {
        private List<Product> products = new List<Product>();

        public void Add(Product product)
        {
            products.Add(product);
        }

        public IIterator<Product> CreateIterator()
        {
            return new ListIterator(productCollection:this);
        }
        public class ListIterator:IIterator<Product>
        {
            private ProductCollection _productCollection { get; }
            private int Index;
            public ListIterator(ProductCollection productCollection)
            {
                _productCollection = productCollection;
            }

            public bool HasNext()
            {
                return Index < _productCollection.products.Count;
            }

            public Product Current()
            {
                return _productCollection.products[Index];
            }

            public void Next()
            {
                Index++;
            }
        }

    }
}
