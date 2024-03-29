﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Structural.Composite
{
    /// <summary>

    /// The 'Component' abstract class

    /// </summary>

    abstract class Component

    {
        protected string name;

        // Constructor

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }

    /// <summary>

    /// The 'Composite' class

    /// </summary>

    class Composite : Component

    {
        private List<Component> _children = new List<Component>();

        // Constructor

        public Composite(string name)
          : base(name)
        {
        }

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            // Recursively display child nodes

            foreach (Component component in _children)
            {
                component.Display(depth + 2);
            }
        }
    }

    /// <summary>

    /// The 'Leaf' class

    /// </summary>

    class Leaf : Component

    {
        // Constructor

        public Leaf(string name)
          : base(name)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
