using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Libro.Creational.Prototype
{
    abstract class CarPrototype
    {
        public abstract CarPrototype Clone();
    }
}
