﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational
{
    abstract class Prototype
    {
        private string _id;
        // Constructor
        public Prototype(string id)
        {
            this._id = id;
        }
        // Gets id
        public string Id
        {
            get { return _id; }
        }
        public abstract Prototype Clone();
    }

    /// <summary>
    /// A 'ConcretePrototype' class 
    /// </summary>

    class ConcretePrototype1 : Prototype
    {
        // Constructor
        public ConcretePrototype1(string id)
          : base(id)
        {
        }

        // Returns a shallow copy
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    /// <summary>
    /// A 'ConcretePrototype' class 
    /// </summary>

    class ConcretePrototype2 : Prototype
    {
        // Constructor
        public ConcretePrototype2(string id)
          : base(id)
        {
        }
        // Returns a shallow copy
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
