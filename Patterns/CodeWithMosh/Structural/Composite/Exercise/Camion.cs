using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Composite.Exercise
{
    class Camion : RisorsaNumerator, IRisorsa
    {
        private readonly List<IRisorsa> risorse=new List<IRisorsa>();
        
        private string Nome { get; }
       

        public Camion(string nome)
        {
            Nome = nome;
        }

       

        public void Add(IRisorsa risorsa)
        {
            risorse.Add(risorsa);
        }


        public void Schiera()
        {
            numerazione++;
            Console.WriteLine(numerazione + " - Schiera " + Nome);
            risorse.ForEach(x => x.Schiera());
        }
       
    }
}
