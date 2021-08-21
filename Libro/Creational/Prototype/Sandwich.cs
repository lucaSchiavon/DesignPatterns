using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Libro.Creational.Prototype
{
    abstract class SandwichPrototype
    {
        public abstract SandwichPrototype Clone();
    }
    class Sandwich : SandwichPrototype
    {
        private string Bread;
        private string Meat;
        private string Cheese;
        private string Veggies;

        public Sandwich(string bread, string meat, string cheese, string veggies)
        {
            Bread = bread;
            Meat = meat;
            Cheese = cheese;
            Veggies = veggies;
        }

        public override SandwichPrototype Clone()
        {
            string ingredientList = GetIngredientList();
            Console.WriteLine("Cloning sandwich with ingredients: {0}", ingredientList.Remove(ingredientList.LastIndexOf(",")));

            return MemberwiseClone() as SandwichPrototype;
        }

        private string GetIngredientList()
        {
            //recupera gli ingredienti da un database... operazione con consumo di risorse
            return Bread + "," + Meat + "," + Cheese + "," + Veggies;
        }
    }

    class SandwichMenu
    {
        private Dictionary<string, SandwichPrototype> _sandwiches
            = new Dictionary<string, SandwichPrototype>();

        public SandwichPrototype this[string name]
        {
            get { return _sandwiches[name]; }
            set { _sandwiches.Add(name, value); }
        }
    }
}
