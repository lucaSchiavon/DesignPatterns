using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational
{
    public interface Prototype2
    {
        Prototype2 Clone();
    }

    public class ConcretePrototypeA2 : Prototype2
    {
        public Prototype2 Clone()
        {
            // Shallow Copy: only top-level objects are duplicated
            //return (Prototype2)this.MemberwiseClone();
         
            // Deep Copy: all objects are duplicated
            return (Prototype2)this.Clone();
        }
    }

    public class ConcretePrototypeB2 : Prototype2
    {
        public Prototype2 Clone()
        {
            // Shallow Copy: only top-level objects are duplicated
            return (Prototype2)MemberwiseClone();

            // Deep Copy: all objects are duplicated
            //return (Prototype)this.Clone();
        }
    }
}
