using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational
{
    public class Animal
    {
        private string id;
        private string name;
        private string pedigreeName;
        private string owner;

        public Animal(string id, string name, string pedigreeName, string owner)
        {
            this.id = id;
            this.name = name;
            this.pedigreeName = pedigreeName;
            this.owner = owner;
        }
    }
        public class AnimalBuilder
    {
        private string id;
        private string name;
        private string pedigreeName;
        private string owner;

        private AnimalBuilder(string id)
        {
            this.id = id;        
        }
        public static AnimalBuilder NewBuilder(string id)
        {
            return new AnimalBuilder(id);
        }

        public AnimalBuilder Name(string name)
        {
            this.name = name;
            return this;
        }

        public AnimalBuilder PedigreeName(string pedigreeName)
        {
            this.pedigreeName = pedigreeName;
            return this;
        }

        public AnimalBuilder Owner(string owner)
        {
            this.owner = owner;
            return this;
        }

        public Animal Build()
        {
            return new Animal(id, name, pedigreeName, owner);
        }
    }
}
