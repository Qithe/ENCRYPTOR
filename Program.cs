using System;

namespace ENCRYPTOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Pirate_encryptor pirate = new Pirate_encryptor();
            string x = pirate.Encrypt("Hello World");
            Console.WriteLine(x);
            Console.WriteLine(pirate.Decrypt(x));
        }


    }
}