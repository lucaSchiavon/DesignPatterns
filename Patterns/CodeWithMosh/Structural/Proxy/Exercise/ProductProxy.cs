using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Proxy.Exercise
{
    class ProductProxy:IProduct
    {
        private int id;
        private String name;
        //private RealProduct product;
        private DbContext dbContext;
        public ProductProxy(int id, DbContext dbContext)
        {
            this.id = id;
            this.dbContext = dbContext;
        }

        public int getId()
        {
            return id;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
            dbContext.markAsChanged(this);
        }
    }
}
