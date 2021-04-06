using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Strategy.Exercise
{
    public class AesEncriptor : IEncriptor
    {
        public void Encript(string Message)
        {
            Console.WriteLine("Encript msg with aes");
        }
    }
}
