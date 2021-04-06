using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Composite.Exercise
{
    class Team : RisorsaNumerator, IRisorsa
    {
       private readonly List<IRisorsa> risorse=new List<IRisorsa>();
        private string nome { get; }
        

        public Team(string nome)
        {
            this.nome = nome;
        }

       

        public void Add(IRisorsa risorsa)
        {
            risorse.Add(risorsa);
        }


        public  void Schiera()
        {
            numerazione++;
            Console.WriteLine(numerazione + " - Schiera " + nome);
            risorse.ForEach(x => x.Schiera());
        }
    }
}
