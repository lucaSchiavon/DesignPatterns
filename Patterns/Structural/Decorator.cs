using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Structural
{
    /// <summary>

    /// The 'Component' abstract class

    /// </summary>

    abstract class Component

    {
        public abstract void Operation();
    }

    /// <summary>

    /// The 'ConcreteComponent' class

    /// </summary>
    //definisce ,l'operazione del componente
    class ConcreteComponent : Component

    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }

    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    //astratto usato per settare un componente ed eseguire le operazioni del componente
    abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }

    /// <summary>
    /// The 'ConcreteDecoratorA' class
    /// </summary>
    //questo decorator fa le operazioni del componente più altre
    class ConcreteDecoratorA : Decorator

    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }

    /// <summary>

    /// The 'ConcreteDecoratorB' class

    /// </summary>

    class ConcreteDecoratorB : Decorator

    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }

        void AddedBehavior()
        {
        }
    }
}
