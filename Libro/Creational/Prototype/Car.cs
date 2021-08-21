using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Libro.Creational.Prototype
{
    class Car : CarPrototype
    {
        public string Color { get; }
        public string CarBody { get; }
        public bool Radio { get; }
        //........
        public Car(string color, string carBody, bool radio)
        {
            Color = color;
            CarBody = carBody;
            Radio = radio;
        }
        public override CarPrototype Clone()
        {
            return MemberwiseClone() as CarPrototype;
        }
    }
}
