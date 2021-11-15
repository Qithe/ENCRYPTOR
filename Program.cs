using System;

namespace ENCRYPTOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Pirate_encryptor pirate = new Pirate_encryptor();
            FileHandeler handler = new FileHandeler();
            string x = pirate.Encrypt("Hello World");
            Console.WriteLine(x);
            Console.WriteLine(pirate.Decrypt(x));
            Console.WriteLine(handler.Reader(@"C:\Users\Oscar\Desktop\", "Test.txt"));

            string y = pirate.Encrypt(handler.Reader(@"C:\Users\Oscar\Desktop\", "Test.txt"));
            Console.WriteLine(y);
            handler.Writer(@"C:\Users\Oscar\Desktop\", "Test.txt", y);



        }


    }
}