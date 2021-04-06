using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Strategy.Exercise
{
    public class ChatClient
    {
        private readonly IEncriptor _encryptionAlgorithm;

        public ChatClient(IEncriptor encryptionAlgorithm)
        {
            this._encryptionAlgorithm = encryptionAlgorithm;
        }

        public void send(String message)
        {
            try
            {
                _encryptionAlgorithm.Encript(message);
            }
            catch 
            {
                throw new InvalidOperationException("Unsupported encryption algorithm");
            }
       
                //throw new InvalidOperationException("Unsupported encryption algorithm");

           // Console.WriteLine("Sending the encrypted message...");
        }
    }

}
