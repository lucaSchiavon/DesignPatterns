using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Proxy.Exercise
{
    public class RealProduct : IProduct
    {
        private int id;
        private String name;

        public RealProduct(int id)
        {
            this.id = id;
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
        }
    }
}
