using System;

namespace ENCRYPTOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Pirate_encryptor pirate = new Pirate_encryptor();
            FileHandeler reader = new FileHandeler();
            string x = pirate.Encrypt("Hello World");
            Console.WriteLine(x);
            Console.WriteLine(pirate.Decrypt(x));
            Console.WriteLine(reader.Reader(@"C:\Users\Oscar\Desktop\Test.txt"));

        }


    }
}